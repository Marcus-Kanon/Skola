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
        public static Player Player { get; set; }
        public static List<Monster> Monsters { get; set; }
        public static int EntCounter { get; set; }

        static Game()
        {
            InputHandler.OnUpKeyHandler += OnUpKey;
            InputHandler.OnDownKeyHandler += OnDownKey;
            InputHandler.OnLeftKeyHandler += OnLeftKey;
            InputHandler.OnRightKeyHandler += OnRightKey;
            InputHandler.OnEnterKeyHandler += OnEnterKey;
            InputHandler.OnIKeyHandler += OnIKey;
            InputHandler.OnSKeyHandler += OnSKey;

            Init();
        }

        public static void Init()
        {
            EntCounter = 0;
            Player = new Player();
            Player.ID = EntCounter;
            EntCounter++;
            MapWriter.AddDrawable(Player);


            Monsters = new List<Monster>();

            for (int i = 0; i < 100; i++)
            {
                Monsters.Add(new Monster_TreeOfDeception());
                Monsters.Add(new Monster_TreeOfDeception());
                Monsters.Add(new Monster_WeirdThing());
                Monsters.Add(new Monster_WeirdThing());
                Monsters.Add(new Monster_WeirdThing());
                Monsters.Add(new Monster_Zombie());
            }

            Random rnd = new();

            for (int i = 0; i < Monsters.Count; i++)
            {
                Monsters[i].X = rnd.Next(0, MapWriter.MapSize);
                Monsters[i].Text.Add("HP: " + Monsters[i].Hp);
                Monsters[i].Text.Add(Monsters[i].Name);
                Monsters[i].ID = EntCounter;
                EntCounter++;

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
            if (monster != null)
            {
                int tempMonsterHp = 0;
                int tempPlayerHp = 0;

                //Adds player damage of amulet
                if (Player.Equipped.Value > 0)
                    tempMonsterHp -= Player.Equipped.Value;

                //Adds player damage from strenth
                tempMonsterHp -= Player.Strength;

                //Adds monster damage to player
                tempPlayerHp -= monster.Damage;

                //Adds temp hp to player based on toughness
                tempPlayerHp += Player.Toughness;

                //Adds amulet toughness
                if (Player.Equipped.Value < 0)
                    tempPlayerHp += Player.Equipped.Value;

                //Adjusting
                if (tempPlayerHp > 0)
                    tempPlayerHp = 0;

                //Adjusting
                if (tempMonsterHp > 0)
                    tempMonsterHp = 0;


                Player.Hp += tempPlayerHp;
                monster.Hp += tempMonsterHp;

                if (monster.Hp <= 0)
                {
                    MonsterDied(monster);
                }

                if (Player.Hp <= 0)
                {
                    PlayerDied();
                }
            }
        }


        public static void PlayerDied()
        {
            Highscore.Highscores.Add(Player.Name + ": " + (-1000000 + Player.Exp).ToString());
            Init();
            Scenes.ScenePlayerDied();
        }


        public static void MonsterDied(Monster monster)
        {
            Random rnd = new();
            int goldDrop = rnd.Next(1, 100);

            Player.Exp += monster.Exp;
            Player.Gold += goldDrop;

            MapWriter.EntityList.Remove(monster);
            Monsters.Remove(monster);


        }

        public static IDrawable AnyMonsterRight()
        {
            var monster = MapWriter.EntityList.FirstOrDefault(q => q.X == Player.X+1 && q.ID!=Player.ID);
            if (monster != default)
            {
                return monster;
            }

            return default;
        }

        public static IDrawable AnyMonsterLeft()
        {
            var monster = MapWriter.EntityList.FirstOrDefault(q => q.X == Player.X - 1 && q.ID != Player.ID);
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
