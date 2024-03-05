using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool Testing = false;

            // Simple if else statement that will either run the game or test the methods depending on the above 'Testing' bool
            if (!Testing)
            {
                RunGame();
            }
            else
            {
                TestMethods();
            }

            // Function to create a testing object and run its methods 
            void TestMethods()
            {
                Testing testing = new Testing();

                testing.TestDieClass();

                testing.TestGameClass();
            }

            // Function to create a game object and execute the main game loop
            void RunGame()
            {
                // Create our game object that will handle the game 
                Game game = new Game();

                // Call the LogInitialDiceRollResults method to log the first 3 die rolls and get there sum printed to the console
                game.LogInitialDiceRollResults();

                // Create a bool to track if the player wishes to keep rolling die
                bool KeepRolling = false;


                // If the input is 'yes' set keep rolling to true to enter our while loop
                if (GetKeepRollingUserInput() == "yes")
                {
                    KeepRolling = true;
                }

                // Check to see if 1 roll has taken place to ensure results only print with valid data
                bool FirstRollInitiated = false;

                while (KeepRolling)
                {
                    // If user input is 'roll' call ExcecuteFurtherDiceRolls method to roll a singular die, if userinput is not 'roll' we exit the while loop
                    if (GetFurtherRollUserInput() == "roll")
                    {
                        game.LogFutherDiceRolls();
                        FirstRollInitiated = true;
                    }
                    else
                    {
                        KeepRolling = false;

                        // Once keep rolling is false call the SeeRollResults method to print the information about all the additional rolls only if atleast 1 roll has taken place
                        if (FirstRollInitiated)
                        {
                            game.SeeRollResults();
                        }
                        else
                        {
                            Console.WriteLine("No rolls taken so no data to display");
                        }
                    }
                }
            }

            String GetKeepRollingUserInput()
            {
                // Take user input to decide if they want to roll more die or not
                Console.WriteLine("If you wish to keep rolling type 'yes', to exit enter any other input:");
                string InitialRollUserInput = Console.ReadLine();

                return InitialRollUserInput;
            }

            String GetFurtherRollUserInput()
            {
                // Have another userinput for the user to keep typing 'roll' for every time they want to roll a die
                Console.WriteLine("Type 'roll' to roll dice, to exit and see summarised results enter any other input:");
                string FurtherRollsUserInput = Console.ReadLine();

                return FurtherRollsUserInput;
            }
        }
    }
}
