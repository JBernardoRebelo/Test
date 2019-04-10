using System;

namespace Simple_Tile_based_2D_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            // World construction
            int x;
            int y;
            int[,] world;

            char tile = '.';

            // Items
            int food;
            int guns;
            int enemy;
            int trap;

            // TEMPORARY TRY CATCH
            try
            {
                // Getting the world size from arguments
                x = Convert.ToInt32(args[0]);
                y = Convert.ToInt32(args[1]);
            }
            // Case nothing is entered in arguments
            catch
            {
                x = 20;
                y = 20;
            }

            world = new int[x, y];

            while (true)
            {

                for (int i = 0; i < x; i++)
                {
                    for (int u = 0; u < y; u++)
                    {

                        world[i, u] = tile;

                    }
                }

                Console.WriteLine(tile);

            }
        }
    }
}
