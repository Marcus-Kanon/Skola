using RPG2.GameLogic;
using RPG2.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.Entities
{
    public class Player : IDrawable
    {
        int exp;
        public int ID { get; set; }
        public string Name { get; set; } = "Macke";
        public int Level { get; set; }
        public int Exp
        {
            get
            {
                return exp;
            }
            set
            {
                exp = value;
                if (exp > Math.Pow(Level, 1.2) * 100)
                    Level++;
            }
        }
        public int Hp { get; set; }
        public int Strength { get; set; }
        public int Touchness { get; set; }
        public int Gold { get; set; }
        public string Drawing { get; set; } = "";
        public int X { get; set; }
        public int DrawRow { get; set; }
        public int DrawHeight { get; set; }
        public int DrawWidth { get; set; }
        public List<string> Text { get; set; } = new List<string>();
        public List<Amulet> Inventory { get; set; } = new List<Amulet>();

        public Player()
        {
            Hp = 100;
            Level = 1;
            Exp = 0;
            X = 5;
            Strength = 1;
            Touchness = 1;

            Drawing =   " O " +
                        "/|\\" +
                        "/ \\";

            DrawRow = 13;
            DrawHeight = 3;
            DrawWidth = 3;
        }
    }
}
