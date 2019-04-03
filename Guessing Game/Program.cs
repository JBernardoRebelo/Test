using System;

namespace Guessing_Game
{
    class Program
    {
        //second guess method!
        static void TheDo()
        {
            //declare variables
            string The2ndWord = "serenity";
            string guessToo = "";
            int guesscount2 = 0;

            //asks for a 2nd word
            //runs code until user guesses it
            //yet again
            do
            {
                //asks for another word
                Console.Write("Guess another word: ");
                //stores input
                guessToo = Console.ReadLine();

                //increments guesscount
                guesscount2++;

                //shows user it's guesses
                Console.WriteLine("Your guesses: " + guesscount2);

                //the condition
            } while (guessToo != The2ndWord && guesscount2 <= 3);//the condition

            //success message
            if (guessToo == The2ndWord)
            {
                Console.WriteLine("You guessed yet again!");
                Console.WriteLine("You won my game, congrats!!1!!");
            }//loser's by guess count to big
            else if (guesscount2 > 3)
            {
                Console.WriteLine("YOU RAN OUT OF GUESSES");
            }
        }
        //main method!
        static void Main(string[] args)
        {
            //declare variables
            string TheWord = "shrouded";
            string guess = "";
            int guesscount = 0;

            //GREETS USER
            Console.WriteLine("Welcome to my guessing game!!");
            Console.WriteLine("You must guess 2 words.");
            Console.WriteLine("You have 3 guesses available");
            Console.WriteLine("in each question so use them well...");

            //as long as guess
            //is different from THE WORD
            //this code will run
            while (guess != TheWord && guesscount <=3)
            {             
               //asks guess to user
                Console.Write("Enter guess: ");
                //stores input
                guess = Console.ReadLine();

                //increments guess count
                guesscount++;

                //show's user it's guesses
                Console.WriteLine("Your guesses: " + guesscount);
            }

            //success message
            if (guess == TheWord)
            {
                Console.WriteLine("You guessed it!");
                TheDo();
            }//loser's by guess count to big
            else if (guesscount > 3)
            {
                Console.WriteLine("YOU RAN OUT OF GUESSES");
            }//loser's message
        }
    }
}
