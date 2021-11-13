using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.GameLogic
{
    public static class Shop
    {
        public static List<Amulet> amuletList = new();

        public static void FillShop()
        {
            Random rnd = new();
            amuletList = new();

            for (int i = 0; i < 5; i++)
            {
                int attribute=0;

                while (attribute == 0)
                {
                    attribute = rnd.Next(-20, 20);
                }

                amuletList.Add(new Amulet() { Name = GetAmuletName(), Value = attribute , Cost = Math.Abs(attribute)*100});
            }
        }

        public static string GetAmuletName()
        {
            string name="";
            Random rnd = new();
            int random = rnd.Next(0, 20);

            switch (random)
            {
                case 0: name = "Amulet of Chaos";
                    break;
                case 1:
                    name = "Amulet of Destruction";
                    break;
                case 2:
                    name = "Programmer's Amulet";
                    break;
                case 3:
                    name = "Amulet of the Loser";
                    break;
                case 4:
                    name = "Cheddar Amulet";
                    break;
                case 5:
                    name = "Amulet of Love";
                    break;
                case 6:
                    name = "Last Wish";
                    break;
                case 7:
                    name = "Stinky Toe";
                    break;
                case 8:
                    name = "Berserker";
                    break;
                case 9:
                    name = "Grass Eater";
                    break;
                case 10:
                    name = "Rolling Death";
                    break;
                case 11:
                    name = "Drunken man's Amulet";
                    break;
                case 12:
                    name = "God is Dead";
                    break;
                case 13:
                    name = "Amulete of Light";
                    break;
                case 14:
                    name = "Amulet of Darkness";
                    break;
                case 15:
                    name = "Amulet of Cold Toilet Seats";
                    break;
                case 16:
                    name = "Amulet of Beer";
                    break;
                case 17:
                    name = "Filthy Amulet";
                    break;
                case 18:
                    name = "Boring Amulete";
                    break;
                case 19:
                    name = "Shitty Amulet";
                    break;
                case 20:
                    name = "Amulet of Wow";
                    break;
                default:
                    break;
            }

            return name;

        }
    }
}
