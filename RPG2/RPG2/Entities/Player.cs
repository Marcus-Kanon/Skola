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
                {
                    Level++;
                    Hp += 100;

                    if (Hp > 200)
                        Hp = 200;
                }
            }
        }
        public int Hp { get; set; }
        public int Strength { get; set; }
        public int Toughness { get; set; }
        public int Gold { get; set; }
        public Amulet Equipped { get; set; }
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
            X = 1000;
            Strength = 1;
            Toughness = 0;
            Equipped = new Amulet() { Name = "", Cost=0, Value=0 };
            Inventory = new List<Amulet>();

            Drawing =   " O " +
                        "/|\\" +
                        "/ \\";

            DrawRow = 13;
            DrawHeight = 3;
            DrawWidth = 3;
        }
    }
}
