using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    public static class Game
    {
        static int choice=0;
        public static int choiceLimit=0;
        public static int Choice
        {
            get
            {
                return choice;
            }
            set
            {
                if (value >= choiceLimit)
                    value = 0;
                if (value < 0)
                    value = choiceLimit;
                choice = value;
            }
        }

        public static void Start()
        {
            choiceLimit = 3;
            if ((Console.ReadKey().Key != ConsoleKey.UpArrow))
            {
                choice--;
                Scenes.Update = true;
            }
            if ((Console.ReadKey().Key != ConsoleKey.DownArrow))
            {
                choice++;
                Scenes.Update = true;
            }

                Scenes.MenuMain(Choice);

            }

            
        }
    }


}
