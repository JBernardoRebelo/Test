using System;

namespace Designing_and_building_classes__
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the colors
            Color green = new Color(0, 255, 10);
            Color pink = new Color(150, 0, 150);
            Color Tblue = new Color(0, 0, 255, 100);

            // Making the balls
            Ball greenBall = new Ball(10, green);
            Ball pinkBall = new Ball(2, pink);
            Ball TblueBall = new Ball(7, Tblue);



        }
    }
}
