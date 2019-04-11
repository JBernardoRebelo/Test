using System;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int x;

            //ask user
            Console.Write("Insert an integer: ");
            //stores and converts variable
            x = Convert.ToInt32(Console.ReadLine());

            //final result
            //if statments using "%"
            //if divisible by 3 and 5
            if (x % 5 == 0 && x % 3 == 0)
            {
                //shows fizzbuzz
                Console.WriteLine("FizzBuzz!");
            }
            //if divisible by 3
            else if (x % 3 == 0)
            {
                //shows fizz
                Console.WriteLine("Fizz!");
            }
            //if divisible by 5
            else if (x % 5 == 0)
            {
                //shows buzz
                Console.WriteLine("Buzz!");
            }           
            //if nothing else is true
            else
            {
                //shows default message, the variable and "!"
                Console.WriteLine(x + "!");
            }
        }
    }
}
