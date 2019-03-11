using System;

namespace An_Interactive_program
{
    class Program
    {
        //random number generator
        //change var names, too confusing
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(0, 100);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(RandomNumber);
            //variables
            string input;
            int num;

            //output to user
            Console.WriteLine("Welcome to guess the number");
            //waits 1 seconds
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Try to guess the number I'm thinking...");
            System.Threading.Thread.Sleep(1000);

            //ask number to user
            //converting the input to int
            Console.Write("Enter any number between 0 and 100: ");
            input = Console.ReadLine();
            num = Convert.ToInt32(input);


            //if statment
            //checks if input is bigger than 10
            //if it is "runs" if
            //if not "runs" else
            //TO DO:
            //switch 0 to "random number" 
            if (num < 0)
            {
                Console.WriteLine("That number is to small");
            }
            //TO DO:
            //switch 100 to "random number" 
            else if (num < 100)
            {
                Console.WriteLine("That number is big enough");
            }
            else
            {
                Console.WriteLine("That number is not valid");
            }

        }
    }
}
