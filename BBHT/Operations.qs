namespace Quantum.BBHT
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Measurement;
    //open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Oracles;
    //open Microsoft.Quantum.AmplitudeAmplification;

	operation MutationPreparation(nQubits: Int) : (Int, Int[], Int[]){
			//First random number is for mutation length
			let ranNum = RandomInt(nQubits);
			//Second random number array is for mutation position
			mutable ranArray = new Int[ranNum];
			//Mutation Posibility controls the posilibity that each mutation performs
			//At the range of 0..99, integers under 15 allows mutation to perform, indicating that the overall
			//mutation posibility is 15%
			mutable mutationPosibility = new Int[ranNum];
			for(idxRan in 0..ranNum-1)
			{
				set ranArray w/= idxRan <- RandomInt(nQubits);
				set mutationPosibility w/= idxRan <- RandomInt(100);
			}
			return (ranNum, ranArray, mutationPosibility);
	}

	/// Implements the operation |x> → (-1)^f(x) |x>
	/// where f(x) = 1 when |x> = |11…1> and 0 otherwise
	operation DatabaseOracle ( markedElements: Int[], markedQubit : Qubit, databaseRegister : Qubit[]) : Unit is Adj + Ctl{
		body(...){
			// Equivalent to CNOT(databaseRegister, markedQubit)
			// The Controlled functor apply its function conditioned on the state |11…1>
			
			// A sequence of integers are marked
            let nMarked = Length(markedElements);
            for (idxMarked in 0..nMarked - 1) {
                // Note: As X accepts a Qubit, and ControlledOnInt only 
                // accepts Qubit[], we use ApplyToEachCA(X, _) which accepts 
                // Qubit[] even though the target is only 1 Qubit.
                (ControlledOnInt(markedElements[idxMarked], ApplyToEachCA(X, _)))(databaseRegister, [markedQubit]);
            }
		}

		//adjoint auto;
	}

	/// # Summary
	/// To perform the uniform superposition on every single Qubit,
	/// and the register |s> will be |++…+> eventually
	/// # Input
	/// ## databaseRegister 
	/// Qubits all in |0> state
	operation UniformSuperpositionOracle(databaseRegister: Qubit[], initialSign: Int, HArray : Int[], XArray : Int[], CNOTLeft : Int[], CNOTRight : Int[]) : Unit is Adj + Ctl{
		body(...){
			let nQubits= Length(databaseRegister);

			let HLength = Length(HArray);
			let XLength = Length(XArray);
			let CNOTLength = Length(CNOTLeft);
			/// INITIAL STATE

            ApplyToEachCA(H, databaseRegister);
			if (initialSign == 1) {
				//Random flip
				for (idxQubit in 0..XLength-1) {
					X(databaseRegister[XArray[idxQubit]]);
				}
				//Random Controlled flip
				for (idxQubit in 0..CNOTLength-1) {
					if(databaseRegister[CNOTLeft[idxQubit]] != databaseRegister[CNOTRight[idxQubit]]){
						CNOT(databaseRegister[CNOTLeft[idxQubit]], databaseRegister[CNOTRight[idxQubit]]);
					}
				}
				//Random Hadamard transformation
				for (idxQubit in 0..HLength-1) {
					H(databaseRegister[HArray[idxQubit]]);
				}
			} 

		}

	}

	/// #Summary
	/// Given a register of qubits initially in the state |00…0>, prepares the start state
	/// as |1〉|N-1〉/√N + |0〉(|0〉+|1〉+...+|N-2〉)/√N.
	operation StatePreparationOracle( markedElements: Int[], markedQubit: Qubit, databaseRegister: Qubit[],
									  ranLength: Int, ranArray: Int[], posibility: Int[], mutation: Int, initialSign: Int, HArray: Int[], XArray: Int[], CNOTLeft: Int[], CNOTRight: Int[]) : Unit is Adj{
		body(...){
			UniformSuperpositionOracle(databaseRegister, initialSign, HArray, XArray, CNOTLeft, CNOTRight);
			
			/// MUTATION may be performed here
			/// NOTE
			for(idxRan in 0..ranLength-1)
			{
				if(posibility[idxRan] < 30 and mutation == 1)
				{
					X(databaseRegister[ranArray[idxRan]]);
					//Message($"Mutation position at: {ranArray[idxRan]}");
				}
			}

			DatabaseOracle(markedElements, markedQubit, databaseRegister);
			//Message($"Mutation length is: {ranLength}");
			
		}
	}
	
	/// #Summary
	/// The Reflection about the marked state
	operation ReflectMarked(markedQubit : Qubit) : Unit{
		body(...){
			//Marked elements always have the marked qubit in the state |1>
			R1(PI(), markedQubit);
		}
	}

	/// #Summary
	/// The Reflection about the |00…0〉 state
	operation ReflectZero(databaseRegister : Qubit[]) : Unit{
        ApplyToEachCA(X, databaseRegister);
        Controlled Z(Rest(databaseRegister), Head(databaseRegister));
        ApplyToEachCA(X, databaseRegister);
	}

	/// #Summary
	/// The Reflection about the start state
	/// The pseudocode can be written as follows
	/// 1. Apply H gates to every qubit
	/// 2. Apply X gates to every qubit
	/// 3. Apply an n-1 controlled Z gate to the 0th qubit
	/// 4. Apply X gates to every qubit
	/// 5. Apply H gates to every qubit
	/// which is also the algorithm described in "Quantum computation and Quantum
	/// information(Chinese Edition)" P231
	operation ReflectStart( markedElements: Int[], markedQubit: Qubit, databaseRegister: Qubit[], mutation: Int) : Unit{
		body(...){
			///Preparation for mutations
			let nQubits = Length(databaseRegister);
			mutable ranNum_I = RandomInt(nQubits);
			mutable ranArray_I = new Int[ranNum_I];
			mutable mutationPosibility_I = new Int[ranNum_I];
			set (ranNum_I, ranArray_I, mutationPosibility_I) = MutationPreparation(nQubits);

			(Adjoint StatePreparationOracle)(markedElements, markedQubit, databaseRegister, ranNum_I, ranArray_I, mutationPosibility_I, mutation, 0, [0], [0], [0], [0]);
			ReflectZero([markedQubit] + databaseRegister);
			
			///Preparation for mutations
			mutable ranNum_II = RandomInt(nQubits);
			mutable ranArray_II = new Int[ranNum_II];
			mutable mutationPosibility_II = new Int[ranNum_II];
			set (ranNum_II, ranArray_II, mutationPosibility_II) = MutationPreparation(nQubits);

			StatePreparationOracle(markedElements, markedQubit, databaseRegister, ranNum_II, ranArray_II, mutationPosibility_II, mutation, 0, [0], [0], [0], [0]);
		}
	}

	/// RS   : ReflectedStart
	/// RM   : ReflectedMarked
	/// M    : Iteration times
	/// |s>  : Start state
    /// (RS · RM)^M |s〉 = sin((2M+1)θ) |1〉|N-1〉 
    ///                  + cos((2M+1)θ) |0〉(|0〉+|1〉+...+|N-2〉)
    /// The product RS · RM is known as the Grover iterator, and each application
    /// of it rotates |s〉 in the two-dimensional subspace by angle 2θ.
	operation QuantumSearch( markedElements: Int[], nIterations: Int, markedQubit: Qubit, databaseRegister: Qubit[], 
	                         HArray: Int[], XArray: Int[], CNOTLeft: Int[], CNOTRight: Int[], mutation: Int) : Unit{
		body(...){
			///Preparation for mutations
			let nQubits = Length(databaseRegister);
			mutable ranNum = RandomInt(nQubits);
			mutable ranArray = new Int[ranNum];
			mutable mutationPosibility = new Int[ranNum];
			set (ranNum, ranArray, mutationPosibility) = MutationPreparation(nQubits);

			let initialSign = 1;
			StatePreparationOracle(markedElements, markedQubit, databaseRegister, ranNum, ranArray, mutationPosibility, mutation, initialSign, HArray, XArray, CNOTLeft, CNOTRight);
			//Loop over Grover iterates
			for(idx in 0..nIterations-1){
				ReflectMarked(markedQubit);
				ReflectStart(markedElements, markedQubit, databaseRegister, mutation);
			}
		}
	}
	
    /// # Summary
    /// Performs quantum search for the marked element and returns an index
    /// to the found element in binary format. Finds the marked element with 
    /// probability sin²((2*nIterations+1) sin⁻¹(1/√N)).
	/// ** θ = sin⁻¹(1/√N) that is because the grover state rotates π/2 in total
	///    to be in the solution state, so N² = sin(π/2) / sin(θ)
	operation ApplyQuantumSearch( markedElements: Int[], nIterations : Int, nDatabaseQubits : Int, 
	                              HArray : Int[], XArray : Int[], CNOTLeft : Int[], CNOTRight : Int[], mutation : Int) : (Result, Int){
		body(...){
			//Variables to store measurement results
			mutable resultSuccess = Zero;
			mutable resultElement = new Result[nDatabaseQubits];
            mutable numberElement = 0;

			using(qubits = Qubit[nDatabaseQubits+1]){
				let markedQubit = qubits[0];
				let databaseRegister = qubits[1..nDatabaseQubits];
				
				QuantumSearch( markedElements, nIterations, markedQubit, databaseRegister, HArray, XArray, CNOTLeft, CNOTRight, mutation);

				set resultSuccess = M(markedQubit);
				set resultElement = MultiM(databaseRegister);

                set numberElement = ResultArrayAsInt(resultElement);

				//Reset all the qubits to the |0> state
				//which is required before deallocation
				if(resultSuccess == One){
					X(markedQubit);
				}
				for(idxResult in 0..nDatabaseQubits-1){
					if(resultElement[idxResult] == One){
						X(databaseRegister[idxResult]);
					}
				}
			}
			// Returns the measurement results of the algorithm
			return(resultSuccess, numberElement);
		}
	}
}
