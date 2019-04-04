using System;

namespace Exceptions_
{
    class Program
    {
        static void Division()
        {
            //declaring variables
            double num1;
            double num2;
            double result;

            //outputs and conversions to user
            Console.Write("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 / num2;
            //outputs division
            Console.WriteLine(result);
        }
        static void TheCalling()
        {
            //"dangerous code", may crash the program
            //if user types in a "0" or a letter
            try
            {
                Division();
            }
            //if the program crashes
            //runs following code:
            catch (DivideByZeroException e)//telling the program to show the error
            {
                //error message
                //outputs what error ocurred
                //in this code I'm specifying that 
                //it will only catch "0" division
                Console.WriteLine(e.Message);

                //runs everything again
                Console.WriteLine("Try again...");
                TheCalling();
            }
            catch (FormatException e)
            {
                //error message
                //outputs what error ocurred
                //in this code I'm specifying that 
                //it will only catch letter input
                Console.WriteLine(e.Message);

                //runs everything again
                Console.WriteLine("Try again...");
                TheCalling();
            }
        }
        static void Main(string[] args)
        {
            //this method will call division
            //and itself if errors ocurr
            TheCalling();

            //program only exits if correct values
            //are inserted and a valid value is returned
        }
    }
}
