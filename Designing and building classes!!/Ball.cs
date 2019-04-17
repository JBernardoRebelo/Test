using System;
using System.Collections.Generic;
using System.Text;

namespace Designing_and_building_classes__
{
    class Ball
    {
        // Declare variables
        private float radius;
        private double vSize;
        private int throwCount = 0;
        // Calling the colors
        private Color color; 

        // Constructor 
        public Ball (int radius, Color color)
        {

            // Seting the color
            this.color = color;
            // Assigning a value to radius
            //this.vSize = 4 / 3 * Math.PI * radius; 

            // Defining in the constructor what each variable does
            vSize = 4 / 3 * Math.PI * radius;

            // Increases number of balls everytime it gets constructed
            throwCount++;
        }

        // Returns volume (size)
        public double GetvSize() => vSize;

        // Returns radius
        public float GetRadius() => radius;

        public int GetthrownBalls() => throwCount;

        // SET
        // Changing radius value if needed
        public void SetRadius(int radius) => this.radius = radius;

        // Sets size of ball to 0
        public void PopSize(double vSize) => vSize = 0;

        // Throw a ball!
        public void Throw()
        {   
            // If the ball hasn't been popped throws!
            if (vSize > 0)
            {
                throwCount++;
            }
        }
    }   
}
