using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // Method called by the program class the execute initial 3 die rolls
        public int[] ExcecuteInitialDiceRolls()
        {
            //Create an array to store the results of the die rolls
            int[] ResultArray = new int[3];

            // Create 3 instances of the die class 
            Die D1 = new Die();
            Die D2 = new Die();
            Die D3 = new Die();

            ResultArray[0] = D1.Roll();
            ResultArray[1] = D2.Roll();
            ResultArray[2] = D3.Roll();

            // Return the result array 
            return ResultArray;
        }

        public void LogInitialDiceRollResults()
        {
            int[] ResultArray = ExcecuteInitialDiceRolls();

            // Then print the results of each returned value to console
            Console.WriteLine("Die roll 1: {0}", ResultArray[0]);
            Console.WriteLine("Die roll 2: {0}", ResultArray[1]);
            Console.WriteLine("Die roll 3: {0}", ResultArray[2]);

            // Create a new variable called Total which is the sum of all 3 returned values
            int Total = ResultArray[0] + ResultArray[1] + ResultArray[2];

            // Print total value to the console
            Console.WriteLine("Total of three die: {0}", Total);
        }

        // List to hold any futher roll values the user initiates 
        List<int> FurtherRollsList = new List<int>();

        // Method called by program class to execute a singular die roll if player requests 
        public int ExcecuteFurtherDiceRolls()
        {
            // Create one instance of the die class
            Die CurrentDie = new Die();

            //Call the roll method on die object
            CurrentDie.Roll();

            // Add the result of the die roll to the die roll list, this will then be used by the see roll results function 
            FurtherRollsList.Add(CurrentDie.CurrentValue);

            // Return the current value of the die we just rolled
            return CurrentDie.CurrentValue;
        }

        public void LogFutherDiceRolls()
        {
            // Call the ExcecuteFurtherDiceRolls method and log the result to console
            Console.WriteLine("Die roll: {0}", ExcecuteFurtherDiceRolls());
        }

        // Method called by program class once player no longer wants to keep rolling the die
        public void SeeRollResults()
        {
            // Total rolls variable is the length of our list which will also be the total rolls
            int TotalRolls = FurtherRollsList.Count;

            // Sum variable will store the sum of all the values, we do this by iterating the list and adding all iterations to sum
            int SumOfRolls = 0;
            foreach (int i in FurtherRollsList)
            {
                SumOfRolls += i;
            }

            // Average variable gets the average value from our list
            double AverageOfRolls = FurtherRollsList.Average();

            // Median of rolls variable will store the calculated median of all the numbers within the values list
            double MedianOfRolls;
            FurtherRollsList.Sort();
            if (TotalRolls % 2 == 0)
            {
                MedianOfRolls = (FurtherRollsList[TotalRolls / 2 - 1] + FurtherRollsList[TotalRolls / 2]) / 2.0;
            }
            else
            {
                MedianOfRolls = FurtherRollsList[TotalRolls / 2];
            }

            // Range of rolls variable will calculate the range of all of the numbers within the values list
            int RangeOfRolls = FurtherRollsList.Max() - FurtherRollsList.Min();

            // Print all our above variables to console for the user to see 
            Console.WriteLine("Total rolls: " + TotalRolls);
            Console.WriteLine("Sum of rolls: " + SumOfRolls);
            Console.WriteLine("Average of rolls: " + AverageOfRolls);
            Console.WriteLine("Median of rolls: " + MedianOfRolls);
            Console.WriteLine("Range of rolls: " + RangeOfRolls);
        }
    }
}
