﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.GameLogic
{
    public static  class Highscore
    {
        public static List<string> Highscores { get; set; }

        static Highscore()
        {
            Highscores = new List<string>();    
        }
    }
}
