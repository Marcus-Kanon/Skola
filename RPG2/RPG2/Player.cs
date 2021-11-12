﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    static internal class Player
    {
        static public string Name { get; set; } = "";
        static public int Level { get; set; }
        static public int Exp { get; set; }
        static public int Hp { get; set; }
        static public string Drawing { get; set; } = "";
        static public int X { get; set; }
        static public int DrawRow { get; set; }
        static public int DrawHeight { get; set; }
        static public int DrawWidth { get; set; }

        static Player()
        {
            Hp = 100;
            Level = 1;
            Exp = 0;
            X = 5;
            Drawing =   " O " +
                        "/|\\" +
                        "/ \\";

            DrawRow = 13;
            DrawHeight = 3;
            DrawWidth = 3;
        }
    }
}
