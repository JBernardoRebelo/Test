using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int index = 1;

            //checks condition
            //as long as condition is true run code
            while (index <= 5)
            {
                //prints index
                Console.WriteLine(index);
                //increments index after output and re-checks
                index++;
            }
        }
    }
}
