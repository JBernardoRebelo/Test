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
        //method new //return
        static int cube (int num)
        {
            //cubing num
            int result = num * num * num;
            //returns (cubed num(result))
            return result;
        }
        static void Main(string[] args)
        {
            int cubedNum = cube(5);
            //calling the method string
            SayHi("Shrouded", 12);
            SayHi("Serenity", 69); 

            //calling the int method
            //"cube" and printing it
            Console.WriteLine(cube(5));

            //another way to print this
            //is to assign a var to the returned value
            Console.WriteLine(cubedNum);

            Console.ReadLine();
        }
    }
}
