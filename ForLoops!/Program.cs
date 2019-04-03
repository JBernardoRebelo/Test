using System;

namespace ForLoops_
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare an array
            int[] NewArray = { 69, 12, 420, 80085, 13, 68 };

            //runs all elements of the array
            for (int i = 0; i < NewArray.Length; i++)//"<=" will output error
            {
                //prints elements of the array
                Console.WriteLine(NewArray[i]);//dont forget the "[i]"or it
                                               //wont know the index of the array
            }
            
        }
    }
}
