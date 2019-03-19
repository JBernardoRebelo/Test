using System;

namespace IfStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            //def variables
            bool isGay = true;
            bool isTall = true;

            //is male AND tall "you are gay"
            //both vars MUST be true
            if (isGay && isTall)
            {
                //isMale is true so print gay
                Console.WriteLine("You are a tall gay");
            }
            //is male OR tall
            //one of them needs to be true
            else if (isGay || isTall)
            {
                //isMale is false so print question
                Console.WriteLine("Why are you gay or tall gay");
            }
            //NOT tall == isTall is false
            else if (isGay && !isTall)
            {
                //isMale is false so print question
                Console.WriteLine("Why are you short gay");
            }
            //if no var is true
            else
            {
                //basically if everything is false
                //the guy is straight and short
                Console.WriteLine("straight short");
            }
        }
    }
}
