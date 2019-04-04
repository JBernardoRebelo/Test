using System;

namespace MoreMethods
{
    class Program
    {
        //method that does the power of --
        static double GetPow(double based, double pow)
        {
            //declare variables
            double result = 1;

            //increments "pow" times
            for (double i = 0; i < pow; i++)
            {
                //multiplies result by itseld
                //"based" times
                result = result * based;
            }
            return result;
        }

        static void Main(string[] args)
        {
            //declare variables
            string input;
            string input2;
            double a1;
            double a2;

            //Ask user for input
            Console.Write("Enter a number: ");
            //converts and stores
            input = Console.ReadLine();
            a1 = Convert.ToDouble(input);

            //asks user for another number
            Console.Write("Enter another number: ");
            //converts and stores
            input2 = Console.ReadLine();
            a2 = Convert.ToDouble(input2);

            //calling the created method 
            //showing the result
            Console.WriteLine(GetPow(a1, a2));
        }
    }
}
