using RPG2.Graphics;
using RPG2.Entities;
using RPG2.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG2.Helpers;

namespace RPG2.GameLogic
{
    public static class Game
    {
        static Player player;
        public static Player Player
        {
            get
            {
                return player;
            }
            set
            {
                Scenes.Player = value;
                player = value;
            }
        }
        public static List<Monster> Monsters;
        public static int entCounter = 0;

        static Game()
        {
            InputHandler.OnUpKeyHandler += OnUpKey;
            InputHandler.OnDownKeyHandler += OnDownKey;
            InputHandler.OnLeftKeyHandler += OnLeftKey;
            InputHandler.OnRightKeyHandler += OnRightKey;
            InputHandler.OnEnterKeyHandler += OnEnterKey;

            Player = new Player();
            Player.ID = entCounter; entCounter++;

            Monsters = new List<Monster>();
            Monsters.Add(new Monster_TreeOfDeception());
            Monsters.Add(new Monster_TreeOfDeception());

            Monsters[0].X = 20;
            Monsters[0].Text.Add("HP: " + Monsters[0].Hp);
            Monsters[0].Text.Add(Monsters[0].Name);
            Monsters[0].ID = entCounter; entCounter++;

            Monsters[1].X = 15;
            Monsters[1].ID = entCounter; entCounter++;
            Monsters[1].Text.Add("HP: " + Monsters[1].Hp);
            Monsters[1].Text.Add(Monsters[1].Name);

            Scenes.Player = Player;

            MapWriter.AddDrawable(Player);
            MapWriter.AddDrawable(Monsters[0]);
            MapWriter.AddDrawable(Monsters[1]);

        }
        public static void PreRound()
        {
            Player.Text = new List<string> { Player.Name, "HP: " + Player.Hp.ToString() };
            Monsters[0].Text = new List<string> { Monsters[0].Name, "HP: " + Monsters[0].Hp.ToString() };
            Monsters[1].Text = new List<string> { Monsters[1].Name, "HP: " + Monsters[1].Hp.ToString() };
        }

        public static void PostRound()
        {
            if(AnyMonsterRight()==null)
            {
                Printer.Print("[Walk right] -->", ConsoleColor.White, 85, 3);
            }
            else
            {
                Printer.Print("[Attack!] -->", ConsoleColor.Red, 85, 3);
            }

            if (AnyMonsterLeft() == null)
            {
                Printer.Print("<-- [Walk left]", ConsoleColor.White, 2, 3);
            }
            else
            {
                Printer.Print("<-- [Attack!]", ConsoleColor.Red, 2, 3);
            }

            
        }

        public static void Start()
        {
            InputHandler.Start();
            Scenes.SceneStarter(Scenes.MenuMain);
        }

        
        public static IDrawable AnyMonsterRight()
        {
            var monster = MapWriter.EntityList.FirstOrDefault(q => q.X == Player.X+1 && q.ID!=player.ID);
            if (monster != default)
            {
                return monster;
            }

            return default;
        }

        public static IDrawable AnyMonsterLeft()
        {
            var monster = MapWriter.EntityList.FirstOrDefault(q => q.X == Player.X - 1 && q.ID != player.ID);
            if (monster != default)
            {
                return monster;
            }

            return default;
        }

        public static void OnUpKey(object? obj, EventArgs args)
        {
        }
        public static void OnDownKey(object? obj, EventArgs args)
        {
        }
        public static void OnLeftKey(object? obj, EventArgs args)
        {
            if (AnyMonsterLeft() == null)
            {
                Player.X--;
            }

        }
        public static void OnRightKey(object? obj, EventArgs args)
        {
            if (AnyMonsterRight() == null)
            {
                Player.X++;
            }
            else
            {
                var monster = Monsters.FirstOrDefault(q => q.ID==AnyMonsterRight().ID);
                monster.Hp -= 5;
                player.Hp -= 1;
            }

        }
        public static void OnEnterKey(object? obj, EventArgs args)
        {
        }

    }

}
