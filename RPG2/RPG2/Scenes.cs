using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    public static class Scenes
    {
        static int choice = 0;
        public static int ChoiceLimit = 0;
        static int OldChoice = 0;
        public static int Choice
        {
            get
            {
                return choice;
            }
            set
            {
                if (value >= ChoiceLimit)
                    value = 0;
                if (value < 0)
                    value = ChoiceLimit - 1;
                choice = value;
            }
        }


        static Scenes()
        {
            InputHandler.OnUpKeyHandler += OnUpKey;
            InputHandler.OnDownKeyHandler += OnDownKey;
            InputHandler.OnLeftKeyHandler += OnLeftKey;
            InputHandler.OnRightKeyHandler += OnRightKey;

        }

        public static void MenuStarter(Action method, int limit)
        {
            ChoiceLimit = limit;
            method();

            while (true)
            {
                if (choice != OldChoice)
                {
                    method();
                    OldChoice = Choice;
                }

            }
        }

        public static void MenuMain()
        {
            
            Console.Clear();
            ConsoleColor color = ConsoleColor.White;

                if (Choice == 0)
                {
                    "> Start Game <\n".Print(ConsoleColor.DarkGreen, 0, 0);
                    "Highscores (... Like you have any)\n".Print(color, 0, 0);
                    "End Game\n".Print(color, 0, 0);
                }
                else if (Choice == 1)
                {
                    "Start Game\n".Print(color, 0, 0);
                    "> Highscores (... Like you have any) <\n".Print(ConsoleColor.DarkGreen, 0, 0);
                    "End Game\n".Print(color, 0, 0);
                }
                else if (Choice == 2)
                {
                    "Start Game\n".Print(color, 0, 0);
                    "Highscores (... Like you have any)\n".Print(color, 0, 0);
                    "> End Game <\n".Print(ConsoleColor.DarkGreen, 0, 0);
                }
        }

        public static void OnUpKey(object? obj, EventArgs args)
        {
            Scenes.Choice--;
        }
        public static void OnDownKey(object? obj, EventArgs args)
        {
            Scenes.Choice++;
        }
        public static void OnLeftKey(object? obj, EventArgs args)
        {
        }
        public static void OnRightKey(object? obj, EventArgs args)
        {
        }

    }
}
