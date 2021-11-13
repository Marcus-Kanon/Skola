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
        public static int entCounter { get; set; } = 0;

        static Game()
        {
            InputHandler.OnUpKeyHandler += OnUpKey;
            InputHandler.OnDownKeyHandler += OnDownKey;
            InputHandler.OnLeftKeyHandler += OnLeftKey;
            InputHandler.OnRightKeyHandler += OnRightKey;
            InputHandler.OnEnterKeyHandler += OnEnterKey;
            InputHandler.OnIKeyHandler += OnIKey;
            InputHandler.OnSKeyHandler += OnSKey;

            Player = new Player();
            Player.ID = entCounter;
            entCounter++;
            MapWriter.AddDrawable(Player);


            Monsters = new List<Monster>();
            Monsters.Add(new Monster_TreeOfDeception());
            Monsters.Add(new Monster_TreeOfDeception());
            Monsters.Add(new Monster_WeirdThing());
            Monsters.Add(new Monster_WeirdThing());
            Monsters.Add(new Monster_WeirdThing());

            Random rnd = new();

            for (int i = 0; i < Monsters.Count; i++)
            {
                Monsters[i].X = rnd.Next(0, MapWriter.MapSize);
                Monsters[i].Text.Add("HP: " + Monsters[i].Hp);
                Monsters[i].Text.Add(Monsters[i].Name);
                Monsters[i].ID = entCounter;
                entCounter++;

                MapWriter.AddDrawable(Monsters[i]);
            }

        }

        public static void Start()
        {
            InputHandler.Start();
            Scenes.SceneStarter(Scenes.MenuMain);
        }

        public static void PreRound()
        {
            Player.Text = new List<string>
            {
                Player.Name,
                "HP: " + Player.Hp.ToString(),
                //"Exp: " + Player.Exp
            };

            for (int i = 0; i < Monsters.Count; i++)
            {
                if(Monsters[i] != null)
                {
                    Monsters[i].Text = new List<string> { Monsters[i].Name, "HP: " + Monsters[i].Hp.ToString() };
                }
            }
            
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

            Printer.Print($"Level: {Player.Level} | Exp: {Player.Exp}", ConsoleColor.Blue, 2, 1);
            Printer.Print($" | Gold: {Player.Gold}", ConsoleColor.Yellow);
        }

        public static void Attack(Monster monster)
        {
            monster.Hp -= player.Strength;

            if (Player.Equipped.Value > 0)
                monster.Hp -= Player.Equipped.Value;

            if(Player.Equipped.Value < 0)
            {
                if (monster.Damage - player.Touchness - Player.Equipped.Value > 0)
                    player.Hp -= (monster.Damage - player.Touchness - Player.Equipped.Value);
            }
            else
            {
                if (monster.Damage - player.Touchness> 0)
                    player.Hp -= (monster.Damage - player.Touchness);
            }

            if (monster.Hp <= 0)
            {
                MonsterDied(monster);
            }
        }

        public static void MonsterDied(Monster monster)
        {
            Random rnd = new();
            int goldDrop = rnd.Next(1, 100);

            player.Exp += monster.Exp;
            player.Gold += goldDrop;

            MapWriter.EntityList.Remove(monster);
            Monsters.Remove(monster);


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
            else
            {
                var monster = Monsters.FirstOrDefault(q => q.ID == AnyMonsterLeft().ID);

                Attack(monster);
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

                Attack(monster);
            }

        }
        public static void OnEnterKey(object? obj, EventArgs args)
        {
        }

        public static void OnIKey(object? obj, EventArgs args)
        {
        }
        public static void OnSKey(object? obj, EventArgs args)
        {
        }

    }

}
