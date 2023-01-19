
/*
AUTHOR: Isaac Waddell
DESCRIPTION: a dice rolling simulator for a fixed 2 dice, shows results at the end
*/

using System;
using System.Collections.Generic;

namespace mission_2 {
    class Program {
        static void Main(string[] args) {

            #nullable disable

            // welcome user, prompt for roll count
            Console.WriteLine("\nWelcome to the dice rolling simulator!\n\nHow many dice rolls would you like to simulate? ");
            double numRolls = Double.Parse(Console.ReadLine());

            // get random number for future rolls, dictionary to store counts of roll values
            var rand = new Random();
            Dictionary<int, double> valueNums = new Dictionary<int, double>();

            // populate dictionary with zeroes, then add for each roll, summing the 2 die values
            for (int i = 2; i < 13; ++i) {
                valueNums.Add(i, 0.0);
            }
            for (uint j = 0; j < numRolls; ++j) {
                int diceRoll = rand.Next(1, 7) + rand.Next(1, 7);
                valueNums[diceRoll] = valueNums[diceRoll] + 1;
            }

            // show user results, with subtitle and total number of rolls, say goodbye
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = {0}\n", numRolls);
            foreach (var kvp in valueNums) {
                string outVal = "";
                for (int k = 0; k < (kvp.Value / numRolls * 100); ++k) {
                    outVal = outVal + '*';
                }
                Console.WriteLine("{0}: {1}", kvp.Key, outVal);
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!\n");

        }
    }
}
