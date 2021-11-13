using RPG2.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.Entities
{
    public class Monster : IDrawable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int X { get; set; }
        public int Exp { get; set; }
        public int Damage { get; set; }
        public int DrawRow { get; set; }
        public int DrawHeight { get; set; }
        public int DrawWidth { get; set; }
        virtual public string Drawing { get; set; } =   " O  " +
                                                        "/()\\" +
                                                        "/ \\ ";
        public List<string> Text { get; set; } = new List<string>();
    }   
}
