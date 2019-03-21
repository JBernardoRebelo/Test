using System;
namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string num1;
            string num2;
            string num3;
            //converted vars
            int n1;
            int n2;
            int n3;

            //ask user for input
            Console.WriteLine("Insert 3 numbers, press enter beetween each one");
            Console.WriteLine("and press enter beetween each one");

            //storing values
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();
            num3 = Console.ReadLine();

            //convert variables to int
            n1 = Convert.ToInt32(num1);
            n2 = Convert.ToInt32(num2);
            n3 = Convert.ToInt32(num3);

            //ifStatment to check required conditions
            if (n2 + n1 == n3)
            {
                //if this condition is true print:
                Console.WriteLine("É possível :) ");
            }
            else if (n3 + n1 == n2)
            {
                //if this condition is true print:
                Console.WriteLine("É possível :) ");
            }
            else if (n2 + n3 == n1)
            {
                //if this condition is true print:
                Console.WriteLine("É possível :) ");
            }
            else
            {
                Console.WriteLine("Impossível :( ");
            }
        }
    }
}
