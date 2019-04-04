using System;

namespace FunWith2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation of a bidimensional array
            //every element must be an array
            int[,] nGrid =
            {
                {1,2},
                {3,4},
                {5,6}
            };

            //another 2D array but
            //NO SPECIFICATION of the elements inside
            //only the sioze of it 
            int[,] newArray = new int[2, 3];

            //prints out elements of array
            //by index position choice
            Console.WriteLine(nGrid[1,1]);
        }
    }
}
