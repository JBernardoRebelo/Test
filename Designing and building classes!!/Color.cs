using System;
using System.Collections.Generic;
using System.Text;

namespace Designing_and_building_classes__
{
    class Color
    {
        // Declare variables
        // ALL COLORS MAX VALUE == 255
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;
        private float grayscale;
        
        // Making a constructor that sets alpha to max
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            // Defines color values
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        // Opaque color
        public Color(byte red, byte green, byte blue)
        {
            // Defines color values
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }
        // GET AND SET METHODS START HERE

        // Returns red value
        public int GetRed() => red;

        // Returns green value
        public int GetGreen() => green;

        // Returns blue value
        public int GetBlue() => blue;

        // Gets grayscale -- returns average of all colors
        public float GetGrayscale()
        {
            // Calculates grayscale
            grayscale = (red + green + blue) / 3;
            return grayscale;
        }
        // Set red value
        public void SetRed(byte red) => this.red = red;

        // Set green value
        public void SetGreen(byte green) => this.green = green;

        // Set blue value
        public void SetBlue(byte blue) => this.blue = blue;
    }
}
