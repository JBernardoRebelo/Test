using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables to be used
            string name;
            string color;
            string pluralNoun;
            string character;

            //asks for name
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            //welcome text
            //outputs player's name
            Console.WriteLine("Welcome to my poem, " + name);

            //asks for color
            Console.Write("Please enter a color: ");
            color = Console.ReadLine();

            //asks for plural noun
            Console.Write("Please enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            //asks for a name
            Console.Write("Enter a name: ");
            character = Console.ReadLine();

            //outputs madlib with the requested variables
            Console.WriteLine("Roses are {0}", color);
            Console.WriteLine("{0} are blue",pluralNoun);
            Console.WriteLine("And I love {0}",character);
        }
    }
}
