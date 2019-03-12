using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array of ints
            int[] lickyNumbers = { 4, 8, 15, 16, 24, 48};
            //array of strings
            string[] crimsonBridge = new string[3];
            //add strings inside the string array
            //if you didnt before
            crimsonBridge[0] = "bebe";
            crimsonBridge[1] = "rere";
            crimsonBridge[2] = "sisi";
            crimsonBridge[3] = "nunu";

            //content changing
            lickyNumbers[1] = 900;

            //outputs wanted array(int) position
            Console.WriteLine(lickyNumbers [0]);

            //updated value "1"
            Console.WriteLine(lickyNumbers[1]);


            Console.ReadLine();
        }
    }
}
