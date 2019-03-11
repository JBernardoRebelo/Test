using System;

namespace TimeMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables
            string h;
            double hours;

            string m;
            double minutes;

            //asks for hours
            Console.WriteLine("Hello, welcome to my time machine...");
            
            Console.WriteLine("Enter the hours: ");
            h = Console.ReadLine();
            hours = Convert.ToDouble(h);

            //user cant type hours over 24
            //and bellow 0
            if (hours > 24 || hours < 0)
            {
                Console.WriteLine("That's not a valid hour, try again");
                Console.ReadLine();
            }

            //asks for minutes
            Console.WriteLine("Enter the minutes: ");
            m = Console.ReadLine();
            minutes = Convert.ToDouble(m);

            //if doenst allow minutes over 60
            //and bellow 0
            if (minutes > 60 || minutes < 0)
            {
                Console.WriteLine("That's not a valid minute, try again");
                Console.ReadLine();
            }

            //if (Input.GetMouseButton(1));

            //outputs time
            Console.WriteLine("nice");
            Console.WriteLine("HOURS: " + hours);
            Console.WriteLine("MINUTES: " + minutes);

        }
    }
}
