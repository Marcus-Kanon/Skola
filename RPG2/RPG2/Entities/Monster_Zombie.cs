using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.Entities
{
    public class Monster_Zombie : Monster
    {

        public Monster_Zombie()
        {
            Hp = 25;
            Damage = 9;
            Drawing =   " () " +
                        " /|\\" +
                        " _|_";
            DrawWidth = 4;
            DrawHeight = 3;
            DrawRow = 13;
            Exp = 400;
            Name = "Zombie";
        }
    }
}
