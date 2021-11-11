using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    public static class Scenes
    {
        static int choice = 0;
        public static int ChoiceLimit { get; set; } = 0;
        static int OldChoice { get; set; } = 0;
        static bool Update { get; set; } = false;
        static bool ContinueLoop = true;
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

        static ConsoleColor textColor = ConsoleColor.White;
        static ConsoleColor textColorSelected = ConsoleColor.DarkGreen;

        static Scenes()
        {
            InputHandler.OnUpKeyHandler += OnUpKey;
            InputHandler.OnDownKeyHandler += OnDownKey;
            InputHandler.OnLeftKeyHandler += OnLeftKey;
            InputHandler.OnRightKeyHandler += OnRightKey;
            InputHandler.OnEnterKeyHandler += OnEnterKey;

        }

        public static void SceneStarter(Action method, int limit)
        {
            ChoiceLimit = limit;
            method();

            while (ContinueLoop)
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

            if (Choice == 0)
            {
                "> Start Game <\n".Print(textColorSelected, 0, 0);
                "Highscores (... Like you have any)\n".Print(textColor, 0, 0);
                "End Game\n".Print(textColor, 0, 0);
            }
            else if (Choice == 1)
            {
                "Start Game\n".Print(textColor, 0, 0);
                "> Highscores (... Like you have any) <\n".Print(textColorSelected, 0, 0);
                "End Game\n".Print(textColor, 0, 0);
            }
            else if (Choice == 2)
            {
                "Start Game\n".Print(textColor, 0, 0);
                "Highscores (... Like you have any)\n".Print(textColor, 0, 0);
                "> End Game <\n".Print(textColorSelected, 0, 0);
            }
        }

        public static void SceneWorld()
        {
            int x=0;
            Console.Clear();
            MapWriter.Draw(x);
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
        public static void OnEnterKey(object? obj, EventArgs args)
        {
            if(Choice == 0)
            {
                ContinueLoop = false;
                MapWriter.Draw(0);

                Choice = 1;
            }
        }
    }
}
