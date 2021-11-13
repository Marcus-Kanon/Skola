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
        static public Player Player { get; set; }
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

            Player = new Player();
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

        public static void SceneEnterWorld()
        {
            ChoiceLimit = 5;

            if (Choice == 0)
            {
                Console.Clear();

                Printer.Print("In this game you walk around and slay", ConsoleColor.Red, 42, 3);
                Printer.Print("monsters in order to become less of a loser", ConsoleColor.Red, 40, 4);
                Printer.Print("[Press enter to continue]", ConsoleColor.White, 48, 6);

                Choice++;
            }
            else if (Choice==1)
            {
                Console.Clear();

                MapWriter.DrawDrawables(Game.Player);

                Printer.Print("This is your Loser: ", ConsoleColor.White, 25, 8);
                Printer.Print("Name your Loser: ", ConsoleColor.White, 25, 9);

                //Ask for name
                Console.CursorVisible = true;
                Game.Player.Name = Console.ReadLine();
                Console.CursorVisible = false;
                
                Game.Player.Text = new List<string> { Game.Player.Name };  

                Choice++;

                MainAction();
            }
            else if (Choice == 2)
            {
                Console.Clear();
                MapWriter.DrawDrawables(Game.Player);
                Printer.Print($"Welcome {Game.Player.Name}. It's quite simple. You can walk to the left or to the right. ", ConsoleColor.Green, 20, 3);
                Printer.Print("You can check your inventory by pressing \"i\". To go to the shop, just press \"s\"", ConsoleColor.Green, 20, 4);
                Printer.Print("[Press enter to continue]", ConsoleColor.White, 50, 7);

                Choice++;
            }
            else if (Choice == 3)
            {
                Console.Clear();
                MapWriter.DrawDrawables(Game.Player);
                Printer.Print($"Your highscore obviously starts at negative one million", ConsoleColor.Green, 35, 3);
                Printer.Print($"and you work your way up from there.", ConsoleColor.Green, 45, 4);
                Printer.Print("[Press enter to continue]", ConsoleColor.White, 48, 6);

                Choice++;
            }
            else if(Choice==4)
            {
                Console.Clear();
                MapWriter.DrawDrawables(Game.Player);
                Printer.Print("Let's Start", ConsoleColor.Green, 48, 3);
                Printer.Print("[Press enter to continue]", ConsoleColor.White, 48, 6);

                Choice++;
            }
        }

        public static void SceneWorld()
        {

            Game.PreRound();
            MapWriter.DrawDrawables(Game.Player);
            Game.PostRound();
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
            //StartScene
            if (MainAction == SceneEnterWorld && Choice < 4)
            {
                MainAction();
            }
            else if(MainAction == SceneEnterWorld && Choice == 4)
            {
                MainAction = SceneWorld;
                MainAction();
            }


            if (Choice == 0 && MainAction==MenuMain)
            {
                MainAction = SceneEnterWorld;
                MainAction();
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
