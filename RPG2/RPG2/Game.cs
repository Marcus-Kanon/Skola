using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    public static class Game
    {
        

        static Game()
        {
            InputHandler.OnUpKeyHandler += OnUpKey;
            InputHandler.OnDownKeyHandler += OnDownKey;
            InputHandler.OnLeftKeyHandler += OnLeftKey;
            InputHandler.OnRightKeyHandler += OnRightKey;

        }

        public static void Start()
        {
            InputHandler.Start();
            Scenes.MenuStarter(Scenes.MenuMain, 3);

        }

        public static void OnUpKey(object? obj, EventArgs args)
        {
        }
        public static void OnDownKey(object? obj, EventArgs args)
        {
        }
        public static void OnLeftKey(object? obj, EventArgs args)
        {
        }
        public static void OnRightKey(object? obj, EventArgs args)
        {
        }

    }

}
