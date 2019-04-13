using System;

namespace Designing_and_building_classes__
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables

            // Instantiate objects -- BALLS

            // A small ball!
            Ball ball1 = new Ball(2);

            // A BIG BALL
            Ball ball2 = new Ball(100);

            Console.WriteLine("Hello World!");




            // TESTS -- DELETE IN FINALL VERSION

            // Printing out the radius
            Console.WriteLine(ball1.GetRadius());
            Console.WriteLine(ball2.GetRadius());

            // Diameter
            Console.WriteLine(ball1.Getdiameter());
            Console.WriteLine(ball2.Getdiameter());

            // Volume
            Console.WriteLine(ball1.GetvSize());
            Console.WriteLine(ball2.GetvSize());

        }
    }
}
