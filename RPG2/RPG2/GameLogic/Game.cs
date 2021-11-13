using RPG2.Graphics;
using RPG2.Entities;
using RPG2.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.GameLogic
{
    public static class Game
    {
        public static Player player;
        public static Monster monster;
        public static Monster monster2;

        static Game()
        {
            InputHandler.OnUpKeyHandler += OnUpKey;
            InputHandler.OnDownKeyHandler += OnDownKey;
            InputHandler.OnLeftKeyHandler += OnLeftKey;
            InputHandler.OnRightKeyHandler += OnRightKey;
            InputHandler.OnEnterKeyHandler += OnEnterKey;

            player= new Player();
            monster = new Monster_TreeOfDeception();
            monster2 = new Monster_TreeOfDeception();

            monster.X = 20;
            monster2.X = 15;

            
            monster.Text.Add("HP: " + player.Hp);
            monster.Text.Add(monster.Name);

            player.Text.Add("HP: " + player.Hp);
            player.Text.Add(player.Name);

            Scenes.player = player;
            Scenes.monster = monster;

            MapWriter.AddDrawable(player);
            MapWriter.AddDrawable(monster);
            MapWriter.AddDrawable(monster2);

        }

        public static void Start()
        {
            InputHandler.Start();
            Scenes.SceneStarter(Scenes.MenuMain);
        }

        public static void OnUpKey(object? obj, EventArgs args)
        {
        }
        public static void OnDownKey(object? obj, EventArgs args)
        {
        }
        public static void OnLeftKey(object? obj, EventArgs args)
        {
            player.X--;
        }
        public static void OnRightKey(object? obj, EventArgs args)
        {
            player.X++;
        }
        public static void OnEnterKey(object? obj, EventArgs args)
        {
        }

    }

}
