using System;

namespace Methods
{
    class Program
    {
        //method just to greet user
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
        static void Main(string[] args)
        {
            //calling the method
            SayHi("Shrouded", 12);
            SayHi("Serenity", 69);
            Console.ReadLine();
        }
    }
}
