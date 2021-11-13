using RPG2.Entities;
using RPG2.Graphics;
using RPG2.Helpers;
using RPG2.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.GameLogic
{
    public static class Scenes
    {
        static int choice = 0;
        public static int ChoiceLimit { get; set; } = 0;
        static bool ContinueLoop { get; set; } = true;
        static public Player player { get; set; }
        static public Monster monster { get; set; }
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

        static ConsoleColor TextColor { get; set; } = ConsoleColor.White;
        static ConsoleColor TextColorSelected { get; set; } = ConsoleColor.DarkGreen;
        static Action MainAction;

        static Scenes()
        {
            InputHandler.OnUpKeyHandler += OnUpKey;
            InputHandler.OnDownKeyHandler += OnDownKey;
            InputHandler.OnLeftKeyHandler += OnLeftKey;
            InputHandler.OnRightKeyHandler += OnRightKey;
            InputHandler.OnEnterKeyHandler += OnEnterKey;

            MainAction = new Action(MenuMain);

            player = new Player();
            monster = new Monster();

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
            ChoiceLimit = 4;

            Console.Clear();

            if (Choice == 0)
            {
                "> Start Game <\n".Print(TextColorSelected, 0, 0);
                "Highscores (... Like you have any)\n".Print(TextColor, 0, 0);
                "Graphics Settings\n".Print(TextColor, 0, 0);
                "End Game\n".Print(TextColor, 0, 0);
            }
            else if (Choice == 1)
            {
                "Start Game\n".Print(TextColor, 0, 0);
                "> Highscores (... Like you have any) <\n".Print(TextColorSelected, 0, 0);
                "Graphics Settings\n".Print(TextColor, 0, 0);
                "End Game\n".Print(TextColor, 0, 0);
            }
            else if (Choice == 2)
            {
                "Start Game\n".Print(TextColor, 0, 0);
                "> Highscores (... Like you have any) <\n".Print(TextColor, 0, 0);
                "> Graphics Settings <\n".Print(TextColorSelected, 0, 0);
                "End Game\n".Print(TextColor, 0, 0);
            }
            else if (Choice == 3)
            {
                "Start Game\n".Print(TextColor, 0, 0);
                "Highscores (... Like you have any)\n".Print(TextColor, 0, 0);
                "Graphics Settings\n".Print(TextColor, 0, 0);
                "> End Game <\n".Print(TextColorSelected, 0, 0);
            }
        }

        public static void MenuGraphicsSetting()
        {
            ChoiceLimit = 0;
            Choice = 0;

            Console.Clear();
            "\nThis is a console app. Do you really think there are any \ngraphics settings, Mr. IonlyPLayGamesWithPhotoRealisticGraphics. \nThis is all you get. Go and play Crysis or something \n\nDo you want me to exit the console for you so \nyou can go and play Crysis?\n\n".Print(TextColor, 0, 0);

            "> Exit Game <\n".Print(TextColorSelected, 0, 0);
        }

        public static void SceneWorld()
        {
            Console.Clear();
            //MapWriter.Draw(Player);

            MapWriter.DrawDrawables(player);
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
                //MapWriter.Draw(25);
                MainAction = SceneWorld;
            }

            if (MainAction == MenuGraphicsSetting && Choice == 0)
            {
                Environment.Exit(0);
            }

            if (Choice == 3 && MainAction == MenuMain)
            {
                Environment.Exit(0);
            }

            if (Choice == 2 && MainAction == MenuMain)
            {
                MainAction = MenuGraphicsSetting;
                MainAction();
            }

        }
    }
}
