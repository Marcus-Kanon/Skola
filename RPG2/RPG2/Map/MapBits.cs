using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.Map
{
    static public class MapBits
    {
        static public string[] mapBits = new string[10];

        static MapBits()
        {
            mapBits[0] =    "     " +
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
                            "|||||";
            mapBits[1] = "     " +
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
        }
    }
}
