using System;
using System.Collections.Generic;
using System.Text;

namespace Grazer
{
    class Grazer
    {
        // Returns index nº of a member of Terrain
        public static int Eat(Terrain terrain)
        {
            // Converting member of enum to int
            int y = (int)terrain;
            return y;
        }

        // Returns index nº of a member of BonusTerrain *10 
        public static int Eat(BonusTerrain bonusTerrain)
        {
            // Converting member of enum to int
            int y = (int)bonusTerrain;

            // Returning y times 10
            return y * 10;
        }
    }
}
