using System;
using System.Collections.Generic;
using System.Text;

namespace Designing_and_building_classes__
{
    class Ball
    {
        // Declare variables
        private int radius;
        private double vSize;
        private int diameter;
        private static int totalBalls = 0;
        private int throwCount = 0;

        // Constructor 
        public Ball (int radius, int throwCount)
        {
            // Assigning a value to radius
            this.radius = radius;

            // Defining in the constructor what each variable does
            vSize = 4 / 3 * Math.PI * radius;
            diameter = radius * 2;

            // Increases number of balls everytime it gets constructed
            totalBalls++;
            throwCount++;
        }

        // Methods

        // Gets
        // Readsonly -- returns volume (size)
        public double GetvSize()
        {
             return vSize;
        }

        // Returns diameter
        public int Getdiameter()
        {
            return diameter;
        }

        // Returns radius
        public int GetRadius()
        {
            return radius;
        }

        // Gets number of balls instatiated
        public int GettotalBalls()
        {
            return totalBalls;
        }

        public int GetthrownBalls()
        {
            return throwCount;
        }

        // SET
        // Changing radius value if needed
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        // Sets size of ball to 0
        public void PopSize(double vSize)
        {
            vSize = 0;
        }

        // Throw a ball!
        public void Throw(int i)
        {   
            // Incrementing throw count until it reaches required number
            while (i > throwCount )
            {
                throwCount++;
            }
            // If the user chooses to throw the balls again only goes +1 up
            if (i == 1)
            {
                throwCount++;
            }
        }
    }   
}
