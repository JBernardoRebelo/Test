using System;
using System.Collections.Generic;
using System.Text;

namespace Designing_and_building_classes__
{
    class Color
    {
        // Declare variables -- colors
        // ALL COLORS MAX VALUE == 255
        private int red;
        private int green;
        private int blue;
        private int alpha;
        private int maxval = 255;
        private float grayscale;

        // Making a constructor
        public Color(int red, int green, int blue, int alpha)
        {
            // Defines color values
            this.red = red;
            this.green = green;
            this.blue = blue;

            // Alpha sets to default value
            alpha = maxval;

            // If values entered pass maxval do this
            if (red > maxval)
            {
                // If user types more than maxval assigne it's value
                Console.WriteLine("Red has been set to 255.");
                red = maxval;

            }
            else if (green > maxval)
            {
                // If user types more than maxval assigne it's value
                Console.WriteLine("Green has been set to 255.");
                green = maxval;
            }
            else if(blue > maxval)
            {
                // If user types more than maxval assigne it's value
                Console.WriteLine("Blue has been set to 255.");
                blue = maxval;
            }

        }

        // GET AND SET METHODS START HERE

        // READONLY GETS
        // Returns red value
        public int GetRed()
        {
            return red;
        }

        // Returns green value
        public int GetGreen()
        {
            return green;
        }

        // Returns blue value
        public int GetBlue()
        {
            return blue;
        }

        // Gets grayscale -- returns average of all colors
        public float GetGrayscale()
        {
            // Calculates grayscale
            grayscale = (red + green + blue) / 3;
            return grayscale;
        }

        // ASSIGNONLY SETS -- doens't return values (void)
        // Set red value
        public void SetRed(int red)
        {
            this.red = red;
        }

        // Set green value
        public void SetGreen(int green)
        {
            this.green = green;
        }

        // Set blue value
        public void SetBlue(int blue)
        {
            this.blue = blue;
        }
    }
}
