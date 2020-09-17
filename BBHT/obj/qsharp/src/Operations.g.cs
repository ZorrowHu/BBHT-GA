#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"MutationPreparation\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nQubits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"MutationPreparation\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":31,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":62}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":72},\"Item2\":{\"Line\":1,\"Column\":88}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" Implements the operation |x> → (-1)^f(x) |x>\",\" where f(x) = 1 when |x> = |11…1> and 0 otherwise\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":32,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":31,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":110},\"Item2\":{\"Line\":1,\"Column\":119}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.BBHT.DatabaseOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":31,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":110},\"Item2\":{\"Line\":1,\"Column\":119}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.BBHT.DatabaseOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":31,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":110},\"Item2\":{\"Line\":1,\"Column\":119}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.BBHT.DatabaseOracle\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":55,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initialSign\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":76}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"HArray\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":83},\"Item2\":{\"Line\":1,\"Column\":89}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"XArray\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":99},\"Item2\":{\"Line\":1,\"Column\":105}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"CNOTLeft\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":115},\"Item2\":{\"Line\":1,\"Column\":123}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"CNOTRight\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":133},\"Item2\":{\"Line\":1,\"Column\":142}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" To perform the uniform superposition on every single Qubit,\",\" and the register |s> will be |++…+> eventually\",\" # Input\",\" ## databaseRegister\",\" Qubits all in |0> state\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":56,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":55,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":162},\"Item2\":{\"Line\":1,\"Column\":171}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.BBHT.UniformSuperpositionOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":55,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":162},\"Item2\":{\"Line\":1,\"Column\":171}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.BBHT.UniformSuperpositionOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":55,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":162},\"Item2\":{\"Line\":1,\"Column\":171}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.BBHT.UniformSuperpositionOracle\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"StatePreparationOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":89,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":69}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":94}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ranLength\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":12},\"Item2\":{\"Line\":2,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ranArray\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":28},\"Item2\":{\"Line\":2,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"posibility\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":45},\"Item2\":{\"Line\":2,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"mutation\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":64},\"Item2\":{\"Line\":2,\"Column\":72}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initialSign\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":79},\"Item2\":{\"Line\":2,\"Column\":90}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"HArray\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":97},\"Item2\":{\"Line\":2,\"Column\":103}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"XArray\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":112},\"Item2\":{\"Line\":2,\"Column\":118}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"CNOTLeft\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":127},\"Item2\":{\"Line\":2,\"Column\":135}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"CNOTRight\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":144},\"Item2\":{\"Line\":2,\"Column\":153}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" #Summary\",\" Given a register of qubits initially in the state |00…0>, prepares the start state\",\" as |1〉|N-1〉/√N + |0〉(|0〉+|1〉+...+|N-2〉)/√N.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"StatePreparationOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":91,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"StatePreparationOracle\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":89,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":172},\"Item2\":{\"Line\":2,\"Column\":175}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.BBHT.StatePreparationOracle\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"ReflectMarked\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":113,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" #Summary\",\" The Reflection about the marked state\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"ReflectMarked\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":114,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"ReflectZero\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":122,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" #Summary\",\" The Reflection about the |00…0〉 state\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"ReflectZero\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":122,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"ReflectStart\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":138,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":84}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"mutation\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":95},\"Item2\":{\"Line\":1,\"Column\":103}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" #Summary\",\" The Reflection about the start state\",\" The pseudocode can be written as follows\",\" 1. Apply H gates to every qubit\",\" 2. Apply X gates to every qubit\",\" 3. Apply an n-1 controlled Z gate to the 0th qubit\",\" 4. Apply X gates to every qubit\",\" 5. Apply H gates to every qubit\",\" which is also the algorithm described in \\\"Quantum computation and Quantum\",\" information(Chinese Edition)\\\" P231\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"ReflectStart\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":139,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"QuantumSearch\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":168,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":60}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":78}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":87},\"Item2\":{\"Line\":1,\"Column\":103}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"HArray\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":27},\"Item2\":{\"Line\":2,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"XArray\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":42},\"Item2\":{\"Line\":2,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"CNOTLeft\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":57},\"Item2\":{\"Line\":2,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"CNOTRight\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":74},\"Item2\":{\"Line\":2,\"Column\":83}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"mutation\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":92},\"Item2\":{\"Line\":2,\"Column\":100}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" RS   : ReflectedStart\",\" RM   : ReflectedMarked\",\" M    : Iteration times\",\" |s>  : Start state\",\" (RS · RM)^M |s〉 = sin((2M+1)θ) |1〉|N-1〉\",\"                  + cos((2M+1)θ) |0〉(|0〉+|1〉+...+|N-2〉)\",\" The product RS · RM is known as the Grover iterator, and each application\",\" of it rotates |s〉 in the two-dimensional subspace by angle 2θ.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"QuantumSearch\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":170,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"ApplyQuantumSearch\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":194,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nDatabaseQubits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":88}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"HArray\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":32},\"Item2\":{\"Line\":2,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"XArray\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":48},\"Item2\":{\"Line\":2,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"CNOTLeft\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":64},\"Item2\":{\"Line\":2,\"Column\":72}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"CNOTRight\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":82},\"Item2\":{\"Line\":2,\"Column\":91}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"mutation\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":101},\"Item2\":{\"Line\":2,\"Column\":109}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Performs quantum search for the marked element and returns an index\",\" to the found element in binary format. Finds the marked element with\",\" probability sin²((2*nIterations+1) sin⁻¹(1/√N)).\",\" ** θ = sin⁻¹(1/√N) that is because the grover state rotates π/2 in total\",\"    to be in the solution state, so N² = sin(π/2) / sin(θ)\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BBHT\",\"Name\":\"ApplyQuantumSearch\"},\"SourceFile\":\"E:/%E5%AD%A6%E4%B9%A0%E8%B5%84%E6%96%99/genetic%20algorithm/Q%23/BBHT-III/BBHT-III/Operations.qs\",\"Position\":{\"Item1\":196,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.BBHT
{
    public class MutationPreparation : Operation<Int64, (Int64,IQArray<Int64>,IQArray<Int64>)>, ICallable
    {
        public MutationPreparation(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Int64,IQArray<Int64>,IQArray<Int64>)>, IApplyData
        {
            public Out((Int64,IQArray<Int64>,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "MutationPreparation";
        String ICallable.FullName => "Quantum.BBHT.MutationPreparation";
        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        public override Func<Int64, (Int64,IQArray<Int64>,IQArray<Int64>)> Body => (__in__) =>
        {
            var nQubits = __in__;
#line 15 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var ranNum = MicrosoftQuantumMathRandomInt.Apply(nQubits);
#line 17 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var ranArray = QArray<Int64>.Create(ranNum);
#line 21 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var mutationPosibility = QArray<Int64>.Create(ranNum);
#line 22 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            foreach (var idxRan in new Range(0L, (ranNum - 1L)))
#line hidden
            {
#line 24 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                ranArray.Modify(idxRan, MicrosoftQuantumMathRandomInt.Apply(nQubits));
#line 25 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                mutationPosibility.Modify(idxRan, MicrosoftQuantumMathRandomInt.Apply(100L));
            }

#line 27 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            return (ranNum, ranArray?.Copy(), mutationPosibility?.Copy());
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut((Int64,IQArray<Int64>,IQArray<Int64>) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,IQArray<Int64>,IQArray<Int64>)> Run(IOperationFactory __m__, Int64 nQubits)
        {
            return __m__.Run<MutationPreparation, Int64, (Int64,IQArray<Int64>,IQArray<Int64>)>(nQubits);
        }
    }

    public class DatabaseOracle : Unitary<(IQArray<Int64>,Qubit,IQArray<Qubit>)>, ICallable
    {
        public DatabaseOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,Qubit,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Int64>,Qubit,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "DatabaseOracle";
        String ICallable.FullName => "Quantum.BBHT.DatabaseOracle";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,Qubit,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedElements,markedQubit,databaseRegister) = __in__;
#line 38 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var nMarked = markedElements.Length;
#line 39 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
#line hidden
            {
#line 43 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (MicrosoftQuantumIntrinsicX, __arg1__))))).Apply((databaseRegister, new QArray<Qubit>(markedQubit)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Int64>,Qubit,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markedElements,markedQubit,databaseRegister) = __in__;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in RangeReverse.Apply(new Range(0L, (nMarked - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (MicrosoftQuantumIntrinsicX, __arg1__))))).Adjoint.Apply((databaseRegister, new QArray<Qubit>(markedQubit)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Int64>,Qubit,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,markedQubit,databaseRegister)) = __in__;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (MicrosoftQuantumIntrinsicX, __arg1__))))).Controlled.Apply((__controlQubits__, (databaseRegister, new QArray<Qubit>(markedQubit))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Int64>,Qubit,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,markedQubit,databaseRegister)) = __in__;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in RangeReverse.Apply(new Range(0L, (nMarked - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (MicrosoftQuantumIntrinsicX, __arg1__))))).Adjoint.Controlled.Apply((__controlQubits__, (databaseRegister, new QArray<Qubit>(markedQubit))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Int64>,Qubit,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> markedElements, Qubit markedQubit, IQArray<Qubit> databaseRegister)
        {
            return __m__.Run<DatabaseOracle, (IQArray<Int64>,Qubit,IQArray<Qubit>), QVoid>((markedElements, markedQubit, databaseRegister));
        }
    }

    public class UniformSuperpositionOracle : Unitary<(IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>)>, ICallable
    {
        public UniformSuperpositionOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "UniformSuperpositionOracle";
        String ICallable.FullName => "Quantum.BBHT.UniformSuperpositionOracle";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (databaseRegister,initialSign,HArray,XArray,CNOTLeft,CNOTRight) = __in__;
#line 58 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var nQubits = databaseRegister.Length;
#line 60 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var HLength = HArray.Length;
#line 61 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var XLength = XArray.Length;
#line 62 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var CNOTLength = CNOTLeft.Length;
#line 65 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicH, databaseRegister));
#line 66 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            if ((initialSign == 1L))
            {
#line 68 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                foreach (var idxQubit in new Range(0L, (XLength - 1L)))
#line hidden
                {
#line 69 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(databaseRegister[XArray[idxQubit]]);
                }

#line 72 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                foreach (var idxQubit in new Range(0L, (CNOTLength - 1L)))
#line hidden
                {
#line 73 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                    if ((databaseRegister[CNOTLeft[idxQubit]] != databaseRegister[CNOTRight[idxQubit]]))
                    {
#line 74 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                        MicrosoftQuantumIntrinsicCNOT.Apply((databaseRegister[CNOTLeft[idxQubit]], databaseRegister[CNOTRight[idxQubit]]));
                    }
                }

#line 78 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                foreach (var idxQubit in new Range(0L, (HLength - 1L)))
#line hidden
                {
#line 79 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                    MicrosoftQuantumIntrinsicH.Apply(databaseRegister[HArray[idxQubit]]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (databaseRegister,initialSign,HArray,XArray,CNOTLeft,CNOTRight) = __in__;
#line hidden
            var nQubits = databaseRegister.Length;
#line hidden
            var HLength = HArray.Length;
#line hidden
            var XLength = XArray.Length;
#line hidden
            var CNOTLength = CNOTLeft.Length;
#line hidden
            if ((initialSign == 1L))
            {
#line hidden
                foreach (var idxQubit in RangeReverse.Apply(new Range(0L, (HLength - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicH.Adjoint.Apply(databaseRegister[HArray[idxQubit]]);
                }

#line hidden
                foreach (var idxQubit in RangeReverse.Apply(new Range(0L, (CNOTLength - 1L))))
#line hidden
                {
#line hidden
                    if ((databaseRegister[CNOTLeft[idxQubit]] != databaseRegister[CNOTRight[idxQubit]]))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((databaseRegister[CNOTLeft[idxQubit]], databaseRegister[CNOTRight[idxQubit]]));
                    }
                }

#line hidden
                foreach (var idxQubit in RangeReverse.Apply(new Range(0L, (XLength - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(databaseRegister[XArray[idxQubit]]);
                }
            }

#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(databaseRegister,initialSign,HArray,XArray,CNOTLeft,CNOTRight)) = __in__;
#line hidden
            var nQubits = databaseRegister.Length;
#line hidden
            var HLength = HArray.Length;
#line hidden
            var XLength = XArray.Length;
#line hidden
            var CNOTLength = CNOTLeft.Length;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, databaseRegister)));
#line hidden
            if ((initialSign == 1L))
            {
#line hidden
                foreach (var idxQubit in new Range(0L, (XLength - 1L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, databaseRegister[XArray[idxQubit]]));
                }

#line hidden
                foreach (var idxQubit in new Range(0L, (CNOTLength - 1L)))
#line hidden
                {
#line hidden
                    if ((databaseRegister[CNOTLeft[idxQubit]] != databaseRegister[CNOTRight[idxQubit]]))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (databaseRegister[CNOTLeft[idxQubit]], databaseRegister[CNOTRight[idxQubit]])));
                    }
                }

#line hidden
                foreach (var idxQubit in new Range(0L, (HLength - 1L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicH.Controlled.Apply((__controlQubits__, databaseRegister[HArray[idxQubit]]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(databaseRegister,initialSign,HArray,XArray,CNOTLeft,CNOTRight)) = __in__;
#line hidden
            var nQubits = databaseRegister.Length;
#line hidden
            var HLength = HArray.Length;
#line hidden
            var XLength = XArray.Length;
#line hidden
            var CNOTLength = CNOTLeft.Length;
#line hidden
            if ((initialSign == 1L))
            {
#line hidden
                foreach (var idxQubit in RangeReverse.Apply(new Range(0L, (HLength - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicH.Adjoint.Controlled.Apply((__controlQubits__, databaseRegister[HArray[idxQubit]]));
                }

#line hidden
                foreach (var idxQubit in RangeReverse.Apply(new Range(0L, (CNOTLength - 1L))))
#line hidden
                {
#line hidden
                    if ((databaseRegister[CNOTLeft[idxQubit]] != databaseRegister[CNOTRight[idxQubit]]))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (databaseRegister[CNOTLeft[idxQubit]], databaseRegister[CNOTRight[idxQubit]])));
                    }
                }

#line hidden
                foreach (var idxQubit in RangeReverse.Apply(new Range(0L, (XLength - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, databaseRegister[XArray[idxQubit]]));
                }
            }

#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, databaseRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> databaseRegister, Int64 initialSign, IQArray<Int64> HArray, IQArray<Int64> XArray, IQArray<Int64> CNOTLeft, IQArray<Int64> CNOTRight)
        {
            return __m__.Run<UniformSuperpositionOracle, (IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>), QVoid>((databaseRegister, initialSign, HArray, XArray, CNOTLeft, CNOTRight));
        }
    }

    public class StatePreparationOracle : Adjointable<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>)>, ICallable
    {
        public StatePreparationOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>)>, IApplyData
        {
            public In((IQArray<Int64>,Qubit,IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "StatePreparationOracle";
        String ICallable.FullName => "Quantum.BBHT.StatePreparationOracle";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Int64>,Qubit,IQArray<Qubit>)> DatabaseOracle
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>)> UniformSuperpositionOracle
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (markedElements,markedQubit,databaseRegister,ranLength,ranArray,posibility,mutation,initialSign,HArray,XArray,CNOTLeft,CNOTRight) = __in__;
#line 93 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            UniformSuperpositionOracle.Apply((databaseRegister, initialSign, HArray, XArray, CNOTLeft, CNOTRight));
#line 97 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            foreach (var idxRan in new Range(0L, (ranLength - 1L)))
#line hidden
            {
#line 99 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                if (((posibility[idxRan] < 30L) && (mutation == 1L)))
                {
#line 101 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(databaseRegister[ranArray[idxRan]]);
                }
            }

#line 106 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            DatabaseOracle.Apply((markedElements, markedQubit, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (markedElements,markedQubit,databaseRegister,ranLength,ranArray,posibility,mutation,initialSign,HArray,XArray,CNOTLeft,CNOTRight) = __in__;
#line hidden
            DatabaseOracle.Adjoint.Apply((markedElements, markedQubit, databaseRegister));
#line hidden
            foreach (var idxRan in RangeReverse.Apply(new Range(0L, (ranLength - 1L))))
#line hidden
            {
#line hidden
                if (((posibility[idxRan] < 30L) && (mutation == 1L)))
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(databaseRegister[ranArray[idxRan]]);
                }
            }

#line hidden
            UniformSuperpositionOracle.Adjoint.Apply((databaseRegister, initialSign, HArray, XArray, CNOTLeft, CNOTRight));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.DatabaseOracle = this.Factory.Get<IUnitary<(IQArray<Int64>,Qubit,IQArray<Qubit>)>>(typeof(DatabaseOracle));
            this.UniformSuperpositionOracle = this.Factory.Get<IUnitary<(IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>)>>(typeof(UniformSuperpositionOracle));
        }

        public override IApplyData __dataIn((IQArray<Int64>,Qubit,IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> markedElements, Qubit markedQubit, IQArray<Qubit> databaseRegister, Int64 ranLength, IQArray<Int64> ranArray, IQArray<Int64> posibility, Int64 mutation, Int64 initialSign, IQArray<Int64> HArray, IQArray<Int64> XArray, IQArray<Int64> CNOTLeft, IQArray<Int64> CNOTRight)
        {
            return __m__.Run<StatePreparationOracle, (IQArray<Int64>,Qubit,IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>), QVoid>((markedElements, markedQubit, databaseRegister, ranLength, ranArray, posibility, mutation, initialSign, HArray, XArray, CNOTLeft, CNOTRight));
        }
    }

    public class ReflectMarked : Operation<Qubit, QVoid>, ICallable
    {
        public ReflectMarked(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectMarked";
        String ICallable.FullName => "Quantum.BBHT.ReflectMarked";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicR1
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var markedQubit = __in__;
#line 117 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            MicrosoftQuantumIntrinsicR1.Apply((MicrosoftQuantumMathPI.Apply(QVoid.Instance), markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit)
        {
            return __m__.Run<ReflectMarked, Qubit, QVoid>(markedQubit);
        }
    }

    public class ReflectZero : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ReflectZero(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectZero";
        String ICallable.FullName => "Quantum.BBHT.ReflectZero";
        protected ICallable MicrosoftQuantumArraysHead
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysRest
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicZ
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var databaseRegister = __in__;
#line 124 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicX, databaseRegister));
#line 125 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            MicrosoftQuantumIntrinsicZ.Controlled.Apply((MicrosoftQuantumArraysRest.Apply<IQArray<Qubit>>(databaseRegister), MicrosoftQuantumArraysHead.Apply<Qubit>(databaseRegister)));
#line 126 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicX, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Head<>));
            this.MicrosoftQuantumArraysRest = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Rest<>));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> databaseRegister)
        {
            return __m__.Run<ReflectZero, IQArray<Qubit>, QVoid>(databaseRegister);
        }
    }

    public class ReflectStart : Operation<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64), QVoid>, ICallable
    {
        public ReflectStart(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Int64>,Qubit,IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ReflectStart";
        String ICallable.FullName => "Quantum.BBHT.ReflectStart";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        protected ICallable<Int64, (Int64,IQArray<Int64>,IQArray<Int64>)> MutationPreparation
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> ReflectZero
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>)> StatePreparationOracle
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (markedElements,markedQubit,databaseRegister,mutation) = __in__;
#line 142 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var nQubits = databaseRegister.Length;
#line 143 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var ranNum_I = MicrosoftQuantumMathRandomInt.Apply(nQubits);
#line 144 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var ranArray_I = QArray<Int64>.Create(ranNum_I);
#line 145 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var mutationPosibility_I = QArray<Int64>.Create(ranNum_I);
#line 146 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var (__arg1__ranNum_I__,__arg1__ranArray_I__,__arg1__mutationPosibility_I__) = MutationPreparation.Apply(nQubits);
#line 146 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            ranNum_I = __arg1__ranNum_I__;
#line 146 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            ranArray_I = new QArray<Int64>(__arg1__ranArray_I__);
#line 146 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            mutationPosibility_I = new QArray<Int64>(__arg1__mutationPosibility_I__);
#line 148 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            StatePreparationOracle.Adjoint.Apply((markedElements, markedQubit, databaseRegister, ranNum_I, ranArray_I?.Copy(), mutationPosibility_I?.Copy(), mutation, 0L, new QArray<Int64>(0L), new QArray<Int64>(0L), new QArray<Int64>(0L), new QArray<Int64>(0L)));
#line 149 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            ReflectZero.Apply(QArray<Qubit>.Add(new QArray<Qubit>(markedQubit), databaseRegister));
#line 152 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var ranNum_II = MicrosoftQuantumMathRandomInt.Apply(nQubits);
#line 153 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var ranArray_II = QArray<Int64>.Create(ranNum_II);
#line 154 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var mutationPosibility_II = QArray<Int64>.Create(ranNum_II);
#line 155 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var (__arg2__ranNum_II__,__arg2__ranArray_II__,__arg2__mutationPosibility_II__) = MutationPreparation.Apply(nQubits);
#line 155 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            ranNum_II = __arg2__ranNum_II__;
#line 155 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            ranArray_II = new QArray<Int64>(__arg2__ranArray_II__);
#line 155 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            mutationPosibility_II = new QArray<Int64>(__arg2__mutationPosibility_II__);
#line 157 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            StatePreparationOracle.Apply((markedElements, markedQubit, databaseRegister, ranNum_II, ranArray_II?.Copy(), mutationPosibility_II?.Copy(), mutation, 0L, new QArray<Int64>(0L), new QArray<Int64>(0L), new QArray<Int64>(0L), new QArray<Int64>(0L)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
            this.MutationPreparation = this.Factory.Get<ICallable<Int64, (Int64,IQArray<Int64>,IQArray<Int64>)>>(typeof(MutationPreparation));
            this.ReflectZero = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(ReflectZero));
            this.StatePreparationOracle = this.Factory.Get<IAdjointable<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>)>>(typeof(StatePreparationOracle));
        }

        public override IApplyData __dataIn((IQArray<Int64>,Qubit,IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> markedElements, Qubit markedQubit, IQArray<Qubit> databaseRegister, Int64 mutation)
        {
            return __m__.Run<ReflectStart, (IQArray<Int64>,Qubit,IQArray<Qubit>,Int64), QVoid>((markedElements, markedQubit, databaseRegister, mutation));
        }
    }

    public class QuantumSearch : Operation<(IQArray<Int64>,Int64,Qubit,IQArray<Qubit>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64), QVoid>, ICallable
    {
        public QuantumSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,Int64,Qubit,IQArray<Qubit>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64)>, IApplyData
        {
            public In((IQArray<Int64>,Int64,Qubit,IQArray<Qubit>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "QuantumSearch";
        String ICallable.FullName => "Quantum.BBHT.QuantumSearch";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        protected ICallable<Int64, (Int64,IQArray<Int64>,IQArray<Int64>)> MutationPreparation
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> ReflectMarked
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64), QVoid> ReflectStart
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>)> StatePreparationOracle
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,Int64,Qubit,IQArray<Qubit>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64), QVoid> Body => (__in__) =>
        {
            var (markedElements,nIterations,markedQubit,databaseRegister,HArray,XArray,CNOTLeft,CNOTRight,mutation) = __in__;
#line 173 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var nQubits = databaseRegister.Length;
#line 174 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var ranNum = MicrosoftQuantumMathRandomInt.Apply(nQubits);
#line 175 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var ranArray = QArray<Int64>.Create(ranNum);
#line 176 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var mutationPosibility = QArray<Int64>.Create(ranNum);
#line 177 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var (__arg1__ranNum__,__arg1__ranArray__,__arg1__mutationPosibility__) = MutationPreparation.Apply(nQubits);
#line 177 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            ranNum = __arg1__ranNum__;
#line 177 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            ranArray = new QArray<Int64>(__arg1__ranArray__);
#line 177 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            mutationPosibility = new QArray<Int64>(__arg1__mutationPosibility__);
#line 179 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var initialSign = 1L;
#line 180 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            StatePreparationOracle.Apply((markedElements, markedQubit, databaseRegister, ranNum, ranArray?.Copy(), mutationPosibility?.Copy(), mutation, initialSign, HArray, XArray, CNOTLeft, CNOTRight));
#line 182 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            foreach (var idx in new Range(0L, (nIterations - 1L)))
#line hidden
            {
#line 183 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                ReflectMarked.Apply(markedQubit);
#line 184 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                ReflectStart.Apply((markedElements, markedQubit, databaseRegister, mutation));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
            this.MutationPreparation = this.Factory.Get<ICallable<Int64, (Int64,IQArray<Int64>,IQArray<Int64>)>>(typeof(MutationPreparation));
            this.ReflectMarked = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(ReflectMarked));
            this.ReflectStart = this.Factory.Get<ICallable<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64), QVoid>>(typeof(ReflectStart));
            this.StatePreparationOracle = this.Factory.Get<IAdjointable<(IQArray<Int64>,Qubit,IQArray<Qubit>,Int64,IQArray<Int64>,IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>)>>(typeof(StatePreparationOracle));
        }

        public override IApplyData __dataIn((IQArray<Int64>,Int64,Qubit,IQArray<Qubit>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> markedElements, Int64 nIterations, Qubit markedQubit, IQArray<Qubit> databaseRegister, IQArray<Int64> HArray, IQArray<Int64> XArray, IQArray<Int64> CNOTLeft, IQArray<Int64> CNOTRight, Int64 mutation)
        {
            return __m__.Run<QuantumSearch, (IQArray<Int64>,Int64,Qubit,IQArray<Qubit>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64), QVoid>((markedElements, nIterations, markedQubit, databaseRegister, HArray, XArray, CNOTLeft, CNOTRight, mutation));
        }
    }

    public class ApplyQuantumSearch : Operation<(IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64), (Result,Int64)>, ICallable
    {
        public ApplyQuantumSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64)>, IApplyData
        {
            public In((IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Result,Int64)>, IApplyData
        {
            public Out((Result,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ApplyQuantumSearch";
        String ICallable.FullName => "Quantum.BBHT.ApplyQuantumSearch";
        protected ICallable<IQArray<Result>, Int64> MicrosoftQuantumConvertResultArrayAsInt
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, IQArray<Result>> MicrosoftQuantumMeasurementMultiM
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Int64>,Int64,Qubit,IQArray<Qubit>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64), QVoid> QuantumSearch
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64), (Result,Int64)> Body => (__in__) =>
        {
            var (markedElements,nIterations,nDatabaseQubits,HArray,XArray,CNOTLeft,CNOTRight,mutation) = __in__;
#line 199 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var resultSuccess = Result.Zero;
#line 200 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var resultElement = QArray<Result>.Create(nDatabaseQubits);
#line 201 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            var numberElement = 0L;
#line hidden
            {
#line 203 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                var qubits = Allocate.Apply((nDatabaseQubits + 1L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 204 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                    var markedQubit = qubits[0L];
#line 205 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                    var databaseRegister = (IQArray<Qubit>)qubits?.Slice(new Range(1L, nDatabaseQubits));
#line 207 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                    QuantumSearch.Apply((markedElements, nIterations, markedQubit, databaseRegister, HArray, XArray, CNOTLeft, CNOTRight, mutation));
#line 209 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                    resultSuccess = MicrosoftQuantumIntrinsicM.Apply(markedQubit);
#line 210 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                    resultElement = new QArray<Result>(MicrosoftQuantumMeasurementMultiM.Apply(databaseRegister));
#line 212 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                    numberElement = MicrosoftQuantumConvertResultArrayAsInt.Apply(resultElement?.Copy());
#line 216 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                    if ((resultSuccess == Result.One))
                    {
#line 217 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                        MicrosoftQuantumIntrinsicX.Apply(markedQubit);
                    }

#line 219 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                    foreach (var idxResult in new Range(0L, (nDatabaseQubits - 1L)))
#line hidden
                    {
#line 220 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                        if ((resultElement[idxResult] == Result.One))
                        {
#line 221 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(databaseRegister[idxResult]);
                        }
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(qubits);
                }
            }

#line 226 "E:\\学习资料\\genetic algorithm\\Q#\\BBHT-III\\BBHT-III\\Operations.qs"
            return (resultSuccess, numberElement);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertResultArrayAsInt = this.Factory.Get<ICallable<IQArray<Result>, Int64>>(typeof(Microsoft.Quantum.Convert.ResultArrayAsInt));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMeasurementMultiM = this.Factory.Get<ICallable<IQArray<Qubit>, IQArray<Result>>>(typeof(Microsoft.Quantum.Measurement.MultiM));
            this.QuantumSearch = this.Factory.Get<ICallable<(IQArray<Int64>,Int64,Qubit,IQArray<Qubit>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64), QVoid>>(typeof(QuantumSearch));
        }

        public override IApplyData __dataIn((IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64) data) => new In(data);
        public override IApplyData __dataOut((Result,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Int64)> Run(IOperationFactory __m__, IQArray<Int64> markedElements, Int64 nIterations, Int64 nDatabaseQubits, IQArray<Int64> HArray, IQArray<Int64> XArray, IQArray<Int64> CNOTLeft, IQArray<Int64> CNOTRight, Int64 mutation)
        {
            return __m__.Run<ApplyQuantumSearch, (IQArray<Int64>,Int64,Int64,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,IQArray<Int64>,Int64), (Result,Int64)>((markedElements, nIterations, nDatabaseQubits, HArray, XArray, CNOTLeft, CNOTRight, mutation));
        }
    }
}