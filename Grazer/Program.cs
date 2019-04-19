using System;

namespace Grazer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing methods from Grazer
            // Calling Terrain enum
            Console.WriteLine
                ($"Jungle Terrain: {Grazer.Eat(Terrain.Jungle)}");
            Console.WriteLine
                ($"Forest Terrain: {Grazer.Eat(Terrain.Forest)}");

            // Calling BonusTerrain enum
            Console.WriteLine
                ($"Water, Bonus Terrain: {Grazer.Eat(BonusTerrain.Water)}");
            Console.WriteLine
                ($"Food, Bonus Terrain: {Grazer.Eat(BonusTerrain.Food)}");

        }
    }
}
