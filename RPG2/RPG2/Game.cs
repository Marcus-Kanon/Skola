using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    public static class Game
    {
        static public int playerPos = 25;

        static Game()
        {
            InputHandler.OnUpKeyHandler += OnUpKey;
            InputHandler.OnDownKeyHandler += OnDownKey;
            InputHandler.OnLeftKeyHandler += OnLeftKey;
            InputHandler.OnRightKeyHandler += OnRightKey;
            InputHandler.OnEnterKeyHandler += OnEnterKey;

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
            Player.X--;
        }
        public static void OnRightKey(object? obj, EventArgs args)
        {
            Player.X++;
        }
        public static void OnEnterKey(object? obj, EventArgs args)
        {
        }

    }

}
