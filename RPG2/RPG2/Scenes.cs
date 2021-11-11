using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    public static class Scenes
    {
        public static bool Update = false;

        public static void MenuMain(int frame)
        {
            Console.Clear();
            ConsoleColor color = ConsoleColor.White;
            //if(Update)
            //{
                if (frame == 0)
                {
                    "> Start Game <\n".Print(color, 0, 0);
                    "Highscore (... Like you have any)\n".Print(color, 0, 0);
                    "End Game\n".Print(color, 0, 0);
                }
                else if (frame == 1)
                {
                    "Start Game\n".Print(color, 0, 0);
                    "> Highscores (... Like you have any) <\n".Print(color, 0, 0);
                    "End Game\n".Print(color, 0, 0);
                }
                else if (frame == 2)
                {
                    "Start Game\n".Print(color, 0, 0);
                    "Highscore (... Like you have any)\n".Print(color, 0, 0);
                    "> End Game <\n".Print(color, 0, 0);
                }
            //} 

            Update = false;
        }

    }
}
