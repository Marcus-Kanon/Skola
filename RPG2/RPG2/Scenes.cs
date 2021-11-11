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
        static Action MainAction;

        static Scenes()
        {
            InputHandler.OnUpKeyHandler += OnUpKey;
            InputHandler.OnDownKeyHandler += OnDownKey;
            InputHandler.OnLeftKeyHandler += OnLeftKey;
            InputHandler.OnRightKeyHandler += OnRightKey;
            InputHandler.OnEnterKeyHandler += OnEnterKey;

            MainAction = new Action(MenuMain);

        }

        public static void SceneStarter(Action method)
        {
            MainAction=method;
            MainAction();

            while (ContinueLoop)
            {
                

            }
        }

        public static void MenuMain()
        {
            ChoiceLimit = 3;

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
            Console.Clear();
            MapWriter.Draw(Game.playerPos);
        }

        public static void OnUpKey(object? obj, EventArgs args)
        {
            if (MainAction == MenuMain)
            {
                Scenes.Choice--;
                
            }

            MainAction();
        }
        public static void OnDownKey(object? obj, EventArgs args)
        {
            if (MainAction == MenuMain)
            {
                Scenes.Choice++;
            }

            MainAction();
        }
        public static void OnLeftKey(object? obj, EventArgs args)
        {
            MainAction();
        }
        public static void OnRightKey(object? obj, EventArgs args)
        {
            MainAction();
        }
        public static void OnEnterKey(object? obj, EventArgs args)
        {
            if(Choice == 0 && MainAction==MenuMain)
            {
                MapWriter.Draw(25);
                MainAction = SceneWorld;
            }
        }
    }
}
