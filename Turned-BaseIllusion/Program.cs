using System;

namespace Exercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int maxturns;
            int turns = 0;
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

            // Reinforces number of maxturns as "game" starts
            Console.WriteLine("You have too survive " + maxturns + " turns");

            // As long as player is alive and turns haven't ran out
            // Does the following
            while (turns < maxturns)
            {
                // Probability/alive check
                chance = rng.NextDouble();

                // Each turn player has chance to die of 2%
                if (chance < 0.02)
                {

                    // Die message
                    Console.WriteLine("Player has died after " + turns + " Turns");
                    break;
                }
                else
                {
                    // Increments number of turns
                    turns++;

                    // Outputs number of turns survived
                    Console.WriteLine("Player has survided turn #" + turns);
                }
            }
        }
    }
}