using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    internal class Monster
    {
        public int Hp { get; set; }
        public int X { get; set; }
        public virtual string Drawing { get; set; } =   " O  " +
                                                        "/()\\" +
                                                        "/ \\ ";
        }   
}
