using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.Entities
{
    public class Monster_WeirdThing : Monster
    {

        public Monster_WeirdThing()
        {
            Hp = 10;
            Damage = 7;
            Drawing =   "<  3" +
                        "<  3" +
                        "< | ";
            DrawWidth = 4;
            DrawHeight = 3;
            DrawRow = 13;
            Exp = 200;
            Name = "Weird Thing";
        }
    }
}
