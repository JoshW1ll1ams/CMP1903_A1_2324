using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public void TestGameClass()
        {
            // Create an instance of the Game class
            Game game = new Game();

            // Test ExecuteInitialDiceRolls method to check for valid return types
            Console.WriteLine("Testing ExecuteInitialDiceRolls method");

            int[] initialRollResults = game.GetExcecuteInitialDiceRolls();
          
            Debug.Assert(initialRollResults.Length == 3, "ERROR ExecuteInitialDiceRolls did not return correct array length");

            // Test ExecuteFurtherDiceRolls method to check for valid return types
            Console.WriteLine("Testing ExecuteFurtherDiceRolls method");
            int furtherRollResult = game.GetExcecuteFurtherDiceRolls();

            Debug.Assert(furtherRollResult >= 1 && furtherRollResult <= 6, "ERROR Further die roll result out of range 1-6.");

        }

        public void TestDieClass()
        {
            // Create an instance of the Die class
            Die die = new Die();

            // Test Roll method of the Die class to check for valid return types
            Console.WriteLine("Testing Roll method of the Die class");
            int rollResult = die.Roll();

            Debug.Assert(rollResult >= 1 && rollResult <= 6, "ERROR die roll result out of range 1-6.");
        }
    }
}
