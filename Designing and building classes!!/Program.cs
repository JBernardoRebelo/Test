using System;

namespace Designing_and_building_classes__
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare "global" variables
            /*
            int radius1;
            int radius2;
            int throwball;
            int throwball2;
            */
            string answer;
            int nBalls;
            Ball[] balls;

            // Ask user for number of balls
            Console.Write("Enter number of balls: ");
            nBalls = Convert.ToInt32(Console.ReadLine());

            // Instatiate array of balls with user's input
            balls = new Ball[nBalls]; 

            // For each ball ask for a radius and a number of throws
            // Storing everything in an array
            for (int i = 0; i < nBalls; i++)
            {
                // Declare for variables
                int radius1;
                int throwball;
                Ball gg;

                // Ask for radius
                Console.Write("Enter a radius for a Ball: ");
                radius1 = Convert.ToInt32(Console.ReadLine());

                // Ask for initial throws
                Console.Write("Throw that Ball: ");
                throwball = Convert.ToInt32(Console.ReadLine());

                // Instatiate gg with all the radius and throws
                gg = new Ball(radius1, throwball);

                // Assigning instatiated array of balls "balls"
                // With data gathered by gg
                balls[i] = gg;

            }

            /*
            Console.Write("Enter a radius for Ball 1: ");
            radius1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Throw Ball 1 : ");
            throwball = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter a radius for Ball 2: ");
            radius2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Throw Ball 2 : ");
            throwball2 = Convert.ToInt32(Console.ReadLine());

            ------- OLD INSTATIATIONS AND CALLS FOR METHODS ----- 
              
            // Instantiate objects -- BALLS

            // A small ball!
            Ball ball1 = new Ball(radius1);

            // A BIG BALL
            Ball ball2 = new Ball(radius2);


            // WTF?!
            ball1.Throw(throwball);
            ball2.Throw(throwball2);

            */

            // TESTS -- DELETE IN FINALL VERSION

            Console.WriteLine("Data that may concern you: ");

            foreach (Ball gg in balls)
            {
                // Interpolated strings for the win
                // Printing out the radius
                // Find way to print each ball with respective name
                Console.WriteLine($"Ball radius: {gg.GetRadius()}");

                // Diameter
                Console.WriteLine($"Ball diameter: {gg.Getdiameter()}");

                // Volume
                Console.WriteLine($"Ball Size: {gg.GetvSize()}");

                // Number of balls -- the object's reference is irrelevant
                Console.WriteLine($"Number of Balls: {gg.GettotalBalls()}");

                // Number of throws
                Console.WriteLine($"Number of throws: {gg.GetthrownBalls()}");


                // Ask if want's to throw again
                Console.WriteLine("Do you wanna throw the balls gain?");
                Console.WriteLine("y/n");
                answer = Console.ReadLine();

                if (answer == "y")
                {
                    // Throws balls
                    gg.Throw(1);

                    // Number of balls -- the object's reference is irrelevant
                    Console.WriteLine($"Balls thrown: {gg.GettotalBalls()}");

                    // Number of throws
                    Console.WriteLine($" Updated number of throws: {gg.GetthrownBalls()}");

                }
                else
                {
                    // Goodbye
                    Console.WriteLine("Goodbye!");
                }


                // THIS LAST PART IS WRONG BEC IT ASKS FOR MORE THROWS
                // IN BEETWEEN THE DATA SHOWING
            }
        }
    }
}
