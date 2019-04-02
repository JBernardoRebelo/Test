using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int indexWhile = 1;
            int indexdoWhi = 12;

            //checks condition
            //as long as condition is true run code
            while (indexWhile <= 5)
            {
                //prints index
                Console.WriteLine(indexWhile);
                //increments index after output and re-checks
                indexWhile++;
                //when while equals false breaks loop
            }

            //markers!!
            Console.WriteLine("End of while loop");
            Console.WriteLine("---------//-------");
            
            //do while
            //executes code in brackets
            //before while condition
            do
            {
                Console.WriteLine(indexdoWhi);
                indexdoWhi++;
            } while (indexdoWhi <= 5);

            //markers!!
            Console.WriteLine("End of do while loop");
            Console.WriteLine("---------//-------");

            //prints values of variables
            //to see the changes of the different
            //types of loops
            Console.WriteLine("Values after loops:");
            Console.WriteLine(indexWhile);
            Console.WriteLine(indexdoWhi);
        }
    }
}
