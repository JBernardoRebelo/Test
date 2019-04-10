using System;

namespace Turned_BaseIllusion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int maxturns;
            int turns = 1;
            bool live = true;
            double chance;
            // Creating the Random object
            Random rng = new Random();

            // Dodging exceptions and erros
            // If code wasn't run through console
            // It would throw an exception -- fixing that
            try
            {
                // Converts console's first argument to int
                maxturns = Convert.ToInt32(args[0]);

                // This wouldn't work if a string was entered
                // On the console, so...
            }
            catch
            {
                // If program crashes
                // Asks user for input
                // And proceeds program
                Console.Write("Enter max turns: ");
                maxturns = Convert.ToInt32(Console.ReadLine());
            }

            // Greets user
            Console.WriteLine("Hello player, this is NOT");
            Console.WriteLine("an interactive program");

            // Reinforces number of maxturns and starts "game"
            Console.WriteLine("You have too survive " + maxturns);
            Console.WriteLine("You only have 1 life... ");
            
            // As long as the number of lives is 1 and maxturns
            // And maxturns asn't been reached run:
            while (live = true && turns <= maxturns)
            {
                // Probability/alive check
                chance = rng.NextDouble();

                // Each turn player has chance to die of 2%
                if (chance < 0.02)
                {
                    live = false;

                    // Die message
                    Console.WriteLine("Player has died after #" + turns + " Turns");
                    break;
                }

                // Status message while alive
                Console.WriteLine("Player has survided Turn #" + turns);

                if (turns == maxturns)
                {
                    // Status message when player survives all turns
                    Console.WriteLine("Player survived after #" + turns + " Turns");
                    break;
                }

                // Increments number of turns
                turns++;   
                
                // End of while
            }
        }
    }
}
