using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    public static class Game
    {
        static int choice = 0;
        public static int ChoiceLimit = 0;
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
                    value = ChoiceLimit-1;
                choice = value;
            }
        }
        static int oldChoice = 0;

        static Game()
        {
            InputHandler.OnUpKeyHandler += OnUpKey;
            InputHandler.OnDownKeyHandler += OnDownKey;
            InputHandler.OnLeftKeyHandler += OnLeftKey;
            InputHandler.OnRightKeyHandler += OnRightKey;

        }

        public static void Start()
        {
            ChoiceLimit = 3;
            Scenes.MenuMain(Choice);

            InputHandler.Start();
            while(true)
            {
                if(choice!=oldChoice)
                {
                    //Scenes.Update = true;
                    Scenes.MenuMain(Choice);
                    oldChoice = Choice;
                }
                    
            }


        }

        public static void OnUpKey(object? obj, EventArgs args)
        {
            Choice--;
        }
        public static void OnDownKey(object? obj, EventArgs args)
        {
            Choice++;
        }
        public static void OnLeftKey(object? obj, EventArgs args)
        {
        }
        public static void OnRightKey(object? obj, EventArgs args)
        {
        }

    }

}
