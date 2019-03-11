using System;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {

            //2 or more intengers will 
            //ALWAYS return an intenger value
            //if you mix an intenger with another type
            //like a double or decimal
            //it will return that type

            //outputs result - sum
            Console.WriteLine(2+2);
            Console.WriteLine("sum");

            //outputs result - subtraction
            Console.WriteLine(12 - 8);
            Console.WriteLine("subtraction");

            //outputs result - division
            Console.WriteLine(16/4);
            Console.WriteLine("division");

            //outputs result - multiplication
            Console.WriteLine(2*2);
            Console.WriteLine("multiplication");

            //outputs result - remainder
            Console.WriteLine(16%6);
            Console.WriteLine("remainder");

            //outputs result
            //does the equation regularly
            Console.WriteLine(4 * 4 - 12);
            Console.WriteLine("equation");

            //outputs result
            //obeys bracket's rules
            Console.WriteLine((4 * (4 - 12)) + 36);
            Console.WriteLine("equation 2");

            //outputs result decimal
            Console.WriteLine(3.1 + 1);
            Console.WriteLine("outputing decimal");

            //using the variables
            //outputs 4
            int num = 4;
            Console.WriteLine(num);
            Console.WriteLine("NUM VAR");

            //increments num (+1)
            num++;
            Console.WriteLine(num);
            Console.WriteLine("incremented num");

            //outputs the absolute value of
            //requested number
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine("Absolute value");

            //outputs numbers to the power of (...) 
            //first argument is raised to the
            //power of the second
            //also accepts decimal nºs
            Console.WriteLine(Math.Pow(4, 2));
            Console.WriteLine("Power of (...)");

            //outputs the square root of (...)
            Console.WriteLine(Math.Sqrt(16));
            Console.WriteLine("Square root");

            //outputs the bigger number
            Console.WriteLine(Math.Max(3, 4));
            Console.WriteLine("Max/Bigger number");

            //outputs the smaller number
            Console.WriteLine(Math.Min(5, 4));
            Console.WriteLine("Minimmum/Smaller number");

            //outputs rounded result
            //according to standart rounding rules
            Console.WriteLine(Math.Round(4.4));
            Console.WriteLine("Rounded");


            //all of these numbers can be replaced by variables
            //only like that you can have a more 
            //practical use of them

            Console.ReadLine();
        }
    }
}
