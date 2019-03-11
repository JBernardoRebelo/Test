using System;

namespace test3
{   
    class Program
    {
        static void Main(string[] args)
        {
            //string variable
            string phrase = "Shrouded academy";

            //unused vars
            char grade = 'A';
            int age = 30;
            double gay = 3.3;
            bool isMale = true;
            
            //printing a message 
            //plus the string variable
            Console.WriteLine("hey \nhey " + phrase + "!!");

            //switches var phrase all to upper case
            Console.WriteLine(phrase.ToUpper());

            //checks if var phrase contains "academy"
            //and returns "true"
            Console.WriteLine(phrase.Contains("academy"));

            //prints 1 char from the string
            //the nº between [] is the 
            //index position
            //0 is the first char of the string
            //this works like an array
            Console.WriteLine(phrase[0]);

            //prints index position of 
            //the first char of wanted string/char
            //if the char is not in the string,
            //this will output -1
            Console.WriteLine(phrase.IndexOf("academy"));

            //prints string chunk assigned 
            //by the 2 parameters
            //this will print index position 0 to 8
            Console.WriteLine(phrase.Substring(0,8));

            Console.ReadLine();
        }
    }
}
 