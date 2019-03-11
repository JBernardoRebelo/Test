using System;

namespace Teste5
{
    class Program
    {
        static void Main(string[] args)
        {
            //startup message
            //ask for name
            Console.Write("Enter your name: ");
            //stores user input as string
            string name = Console.ReadLine();

            //ask for age
            Console.Write("Now, your age: ");
            string age = Console.ReadLine();

            //prints message with the user's name
            Console.WriteLine("Hello " + name + " and you are " + age);

            //asks for nº input
            Console.WriteLine("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            //asks for 2ºnd nº input
            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //the convert method allows us 
            //to convert any kind of number to any type of data type
            //as long as it's common to the data types you covert
            //in this case, the user input can be converted to a
            //number because it's already one
            //you cant convert letters to numbers
            //this won't convert decimal to int
            //to this you must specify that you want
            //to return doubles

            //outputs sum between
            //requested values
            Console.WriteLine("The sum of the entered nºs is: ");
            Console.WriteLine(num + num2);


            //sum between the converted var num
            //and an int
            //Console.WriteLine(num + 6);


            Console.ReadLine();
        }
    }
}
