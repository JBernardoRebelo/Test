using System;
using System.Collections.Generic;
using System.Text;

namespace Designing_and_building_classes__
{
    class Color
    {
        // Declare variables -- colors
        // ALL COLORS MAX VALUE == 250
        private int red;
        private int green;
        private int blue;
        private int alpha;
        private int maxval = 250;
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
