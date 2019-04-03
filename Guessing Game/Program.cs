using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string TheWord = "shrouded";
            string guess = "";

            //as long as guess
            //is different from THE WORD
            //this code will run
            while (guess != TheWord)
            {
                //asks guess to user
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
            }

            //success message
            Console.WriteLine("You guessed it!");

        }
    }
}
