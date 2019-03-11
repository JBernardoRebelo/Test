using System;

namespace An_Interactive_program
{
    class Program
    {
        //random number generator
        //static meaning it can be accessible
        //through other methods
        //arguments = min, max
        static int RandomNumber(int min, int max)
        {
            //def's var number
            Random number = new Random();
            //returns int from 0 to 100
            return number.Next(0, 100);
        }

        //I want to put my if cicle 
        //here but I cant:

   

        static void Main(string[] args)
        {
            //Console.WriteLine(RandomNumber);
            //variables
            string input;
            int num;
            //randomnumber
            int randnum = RandomNumber(0, 100);

            //check if random number is working
            Console.WriteLine(randnum);

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
            if (num < 100)
            {
                //checks if number input can be used
                //and waits
                Console.WriteLine("That number will do...");
                System.Threading.Thread.Sleep(1000);

                //starts another if cicle
                //checks if number is right
                if (num == randnum)
                {
                    //program ends congratulating the user
                    Console.WriteLine("Yes! That WAS the");
                    Console.WriteLine("number I was thinking!!!");
                    Console.ReadLine();
                }
                else if (num < randnum)
                {
                    //must try if it works to add another input
                    Console.WriteLine("That number is too small!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You have one more chance...");
                }
                else if (num > randnum)
                {
                    Console.WriteLine("That number is to big!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You have one more chance...");
                }
            }
            else if (num < 0)
            {
                //checks if number input can be used
                //and waits
                Console.WriteLine("That number is to small");
                System.Threading.Thread.Sleep(1000);
            }

            else if (num > 100)
            {
                //checks if number input can be used
                //and waits
                Console.WriteLine("That number is to big !!");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("That number is not valid");
                Console.ReadLine();
            }
        }
    }
}
