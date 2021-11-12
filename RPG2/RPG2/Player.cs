using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    internal class Player
    {
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public int Exp { get; set; }
        public int Hp { get; set; }

        Player(string name)
        {
            Hp = 100;
            Level = 1;
            Exp = 0;
            Name = name;
        }
    }
}
