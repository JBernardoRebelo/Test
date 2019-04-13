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

        // Constructor 
        public Ball (int radius)
        {
            // Assigning a value to radius
            this.radius = radius;

            // Defining in the constructor what each variable does
            vSize = 4 / 3 * Math.PI * radius;
            diameter = radius * 2;
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


    }
}
