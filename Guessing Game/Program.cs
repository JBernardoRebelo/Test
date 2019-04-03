using System;

namespace Guessing_Game
{
    class Program
    {
        static void TheDo()
        {
            //declare variables
            string The2ndWord = "serenity";
            string guessToo = "";

            //asks for a 2nd word
            //runs code until user guesses it
            //yet again
            do
            {
                //asks for another word
                Console.Write("Guess another word: ");
                //stores input
                guessToo = Console.ReadLine();
            } while (guessToo != The2ndWord);//the condition

            Console.WriteLine("You guessed yet again!");

        }
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
                //stores input
                guess = Console.ReadLine();
            }

            //success message
            Console.WriteLine("You guessed it!");

            //calls 2nd guess method
            TheDo();
        }
    }
}
