using System;

namespace Complex_ishProgram
{
    class Program
    {
        //returns bigger number //method
        static int GetMax(int num1, int num2, int num3)
        {
            //declare result var
            int result;

            //compares parameters
            //wich number is bigger
            //using "&&" so the loop isn't to big
            if (num1 > num2 && num1 > num3)
            {
                //will assign num2 value to result
                //because this number is bigger than
                //num2 and num3
                result = num1;
            }
            //using 2 comparisons in 1 if yet again
            else if (num2 > num1 && num2 > num3)
            {
                //will assign num2 value to result
                //because this number is bigger than
                //num1 and num3
                result = num2;
            }
            else
            {
                //will assign num3 value to result
                result = num3;
            }
            return result;
        }
        //main method
        static void Main(string[] args)
        {
            //outputs bigger value
            //as done in the GetMax method
            Console.WriteLine(GetMax (9, 10, 11));

            Console.ReadLine();
        }

    }
}
