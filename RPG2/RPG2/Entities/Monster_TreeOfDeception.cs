﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.Entities
{
    public class Monster_TreeOfDeception : Monster
    {

        public Monster_TreeOfDeception()
        {
            Hp = 500;
            Drawing =   " ( 3" +
                        " ( 3" +
                        "  | ";
            DrawWidth = 4;
            DrawHeight = 3;
            DrawRow = 13;
            Name = "Tree of Deception";
        }
    }
}
