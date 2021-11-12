using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.Map
{
    static public class MapBits
    {
        static public MapBit[] mapBits = new MapBit[10];

        static MapBits()
        {
            mapBits[0] = new MapBit();
            mapBits[0].Color = ConsoleColor.Green;
            mapBits[0].Drawing =    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    ",,,,," +
                                    "^^^^^";

            mapBits[1] = new MapBit();
            mapBits[1].Color = ConsoleColor.Green;
            mapBits[1].Drawing =    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "^^^^^";

            mapBits[2] = new MapBit();
            mapBits[2].Color = ConsoleColor.DarkGreen;
            mapBits[2].Drawing =    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    " ___ " +
                                    "/ ..\\" +
                                    "^^^^^";

            mapBits[3] = new MapBit();
            mapBits[3].Color = ConsoleColor.DarkGreen;
            mapBits[3].Drawing =    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    " \\\\/ " +
                                    "^^^^^";

            mapBits[4] = new MapBit();
            mapBits[4].Color = ConsoleColor.Green;
            mapBits[4].Drawing =    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "^^^^^";

            mapBits[5] = new MapBit();
            mapBits[5].Color = ConsoleColor.Green;
            mapBits[5].Drawing =    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "^^^^^";

            mapBits[6] = new MapBit();
            mapBits[6].Color = ConsoleColor.Green;
            mapBits[6].Drawing =    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    "     " +
                                    ",,,,," +
                                    "^^^^^";
        }
    }
}
