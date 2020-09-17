using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Quantum.BBHT
{
    class Driver
    {
        public static void Pause()
        {
            System.Console.WriteLine("\n\nPress any key to continue...\n\n");
            System.Console.ReadKey();
        }

        //Best iteration numbers to a specific number of marked elements based on experimental data
        public static int Statics(int databaseSize, int nMarkedElements)
        {
            int elementsIterations = 0;
            int iterationsTest = (int)((Math.PI / 2.0 / (Math.Asin(Math.Sqrt(nMarkedElements) / Math.Sqrt(databaseSize))) - 1) / 2.0) + 1;

            // We now execute the quantum search and verify that the success 
            // probability matches the theoretical prediction. 
            var classicalSuccessProbability = (double)(nMarkedElements) / databaseSize;
            double quantumSuccessProbability = 0;
            int nIterations = 0;
            //Search around the theoretical iteration number to see if there's any better
            for (int i = iterationsTest - 3; i <= iterationsTest + 7; i++)
            {
                if (i <= 0)
                {
                    continue;
                }
                var probs = Math.Pow(Math.Sin((2.0 * (double)i + 1.0) * Math.Asin(Math.Sqrt(nMarkedElements) / Math.Sqrt(databaseSize))), 2.0);
                if (quantumSuccessProbability < probs)
                {
                    quantumSuccessProbability = probs;
                    nIterations = i;
                }
            }
            elementsIterations = nIterations;
            return elementsIterations;
        }

        /// <summary>
        /// The aim of this program is to find out the maximum |11…1> in the 
        /// n-qubits domain with grover algorithm speeding up.
        /// </summary>
        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            // Quantum Database Search with Manual Oracle Definitions

            // N = 2^n
            var nDatabaseQubits = 6;
            var databaseSize = (int)Math.Pow(2.0, nDatabaseQubits);

            double overallProbability = 0.0;
            double overallIteration = 0.0;
            double overallAcceleration = 0.0;

            double overallMutationSuccess = 0.0;
            double overallMutationAcceleration = 0.0;
            int totalMutation = 0;

            int caseNum = 50;
            foreach(var cs in Enumerable.Range(0, caseNum))
            {
                // We define the marked elements. These must be smaller than `databaseSize`
                //var markedElements = new long[] { 255, 250, 251, 254, 234 };
                var markedElements = new long[] { };
                List<long> Elements = markedElements.ToList();

                //Generate some random integers for grover to find
                Random rnd = new Random();
                //At least one individual is marked
                int ranLength = rnd.Next(1, (int)Math.Sqrt(databaseSize));
                foreach (var i in Enumerable.Range(0, ranLength))
                {
                    int ranNum = rnd.Next(0, databaseSize);
                    Elements.Add(ranNum);
                }

                markedElements = Elements.ToArray();

                var nMarkedElements = markedElements.Length;

                // Grover iteration times to amplify the marked subspace
                // Note that the domain is 64 and the solution to this
                // problem can only be one, so the number of iterations
                // is (π/4)(√N/1)
                var nIterations = Statics(databaseSize, nMarkedElements);

                // Number of queries to database oracle.
                var queries = nIterations * 2 + 1;

                var quantumSuccessProbability = Math.Pow(Math.Sin((2.0 * (double)nIterations + 1.0) * Math.Asin(1.0 / Math.Sqrt(databaseSize))), 2.0);
                int iterationsTest = (int)((Math.PI / 2.0 / (Math.Asin(Math.Sqrt(nMarkedElements) / Math.Sqrt(databaseSize))) - 1) / 2.0) + 1;

                var repeats = 50;

                Console.Write(
                    $"Marked elements: {string.Join(",", markedElements.Select(x => x.ToString()).ToArray())}" +
                    $" Initial iteration: {iterationsTest}" +
                    $" Iterations: {nIterations}" +
                    //$" Theoretical probability: {quantumSuccessProbability}\n\n" +
                    "\n");

                //Perform mutaion or not
                var mutate = 1;
                //Record the maximun probability of find a result and its corresponding iteration number
                var maxProbability = 0.0;
                var correspondingIterations = 0;
                //More iteration numbers can be tested in the following line
                foreach (var iterAttempt in Enumerable.Range(1, nIterations + (int)Math.Sqrt(nIterations)))
                {
                    Console.WriteLine($"-------------------No.{iterAttempt} iteration attempt in No.{cs+1} case test-------------------");
                    var probsWithoutMutation = 0.0;
                    for (int mutation = 0; mutation <= mutate; mutation++)
                    {
                        var successCount = 0;
                        //This loop controls whether mutation should be performed or not
                        foreach (var idxAttempt in Enumerable.Range(0, repeats))
                        {
                            //Which qubit should perform Hadamard transformation
                            var H = new long[] { };
                            List<long> HList = H.ToList();
                            //Which qubit should flip
                            var X = new long[] { };
                            List<long> XList = X.ToList();
                            //Which qubit should control
                            var CNOTLeft = new long[] { };
                            List<long> CNOTLeftList = CNOTLeft.ToList();
                            //Which qubit should be controlled to flip
                            var CNOTRight = new long[] { };
                            List<long> CNOTRightList = CNOTRight.ToList();

                            //Note: the number of Hize is yet to reconsider
                            //int HSize = rnd.Next((int)Math.Sqrt(databaseSize), databaseSize / 2);
                            int HSize = rnd.Next(0, (int)Math.Sqrt(databaseSize));
                            foreach (var idxRan in Enumerable.Range(0, HSize))
                            {
                                HList.Add(rnd.Next(0, nDatabaseQubits));
                            }
                            H = HList.ToArray();

                            //Not working
                            int XSize = rnd.Next(0, (int)Math.Sqrt(databaseSize));
                            foreach (var idxRan in Enumerable.Range(0, XSize))
                            {
                                XList.Add(rnd.Next(0, nDatabaseQubits));
                            }
                            X = XList.ToArray();

                            //Note: the number of CNOTSize is yet to reconsider
                            int CNOTSize = rnd.Next(databaseSize / 2, databaseSize);
                            foreach (var idxRan in Enumerable.Range(0, CNOTSize))
                            {
                                CNOTLeftList.Add(rnd.Next(0, nDatabaseQubits));
                                CNOTRightList.Add(rnd.Next(0, nDatabaseQubits));
                            }
                            CNOTLeft = CNOTLeftList.ToArray();
                            CNOTRight = CNOTRightList.ToArray();

                            var task = ApplyQuantumSearch.Run(sim, new QArray<long>(markedElements), iterAttempt, nDatabaseQubits,
                                                                   new QArray<long>(H), new QArray<long>(X), new QArray<long>(CNOTLeft), new QArray<long>(CNOTRight), mutation);

                            //Extract the marked qubit and the database register
                            var data = task.Result;
                            var markedQubit = data.Item1;
                            var databaseRegister = data.Item2;
                            //var resultTest = data.Item3 == Result.One ? 1 : 0;

                            //If the returned marked qubit is One,
                            //that means the grover search succeed.
                            successCount += markedQubit == Result.One ? 1 : 0;
                        }

                        var Probability = Math.Round((double)successCount / ((double)repeats), 5);
                        if (mutation == 0)
                        {
                            Console.WriteLine("Random initial State");
                            probsWithoutMutation = Probability;
                        }
                        else
                        {
                            Console.WriteLine("With Mutation");
                        }
                        if (Probability > maxProbability && mutation == 0)
                        {
                            maxProbability = Probability;
                            correspondingIterations = iterAttempt;
                        } else if (mutation == 1 && Probability > probsWithoutMutation)
                        {
                            overallMutationSuccess++;
                            overallMutationAcceleration += (Probability - probsWithoutMutation);
                        }
                        Console.WriteLine("Iterations: " + iterAttempt + " Probability: " + Probability);
                    }
                    totalMutation++;
                }
                double acclerationRate = (double)(nIterations > iterationsTest ? nIterations : iterationsTest) / correspondingIterations;
                Console.WriteLine("\nIterations: " + correspondingIterations + " Probability: " + maxProbability + " Accleration Rate: " + acclerationRate);
                Console.WriteLine("Total mutation: " + totalMutation + " Overall mutation success: " + overallMutationSuccess);
                Console.WriteLine("Contemporary Mutation Success: " + overallMutationSuccess/totalMutation + " and Mutation Acceleration : " + overallMutationAcceleration/ overallMutationSuccess + "\n");
                overallIteration += correspondingIterations;
                overallProbability += maxProbability;
                overallAcceleration += acclerationRate;
            }
            Console.WriteLine("Overall probability: " + overallProbability/caseNum + " iterations: " + overallIteration / caseNum + " Acceleration Rate: " + overallAcceleration / caseNum);
            Pause();
        }
    }
}