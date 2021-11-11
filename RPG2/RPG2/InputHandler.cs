﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    static public class InputHandler
    {
        static public CancellationTokenSource tokenSource = new();
        static public event EventHandler? OnDownKeyHandler;
        static public event EventHandler? OnUpKeyHandler;
        static public event EventHandler? OnLeftKeyHandler;
        static public event EventHandler? OnRightKeyHandler;

        static public void Start()
        {
            TaskFactory taskFactory = new TaskFactory(tokenSource.Token,
                TaskCreationOptions.LongRunning, TaskContinuationOptions.LongRunning, null);
            taskFactory.StartNew(() => InputLoop());
        }


        static public Task InputLoop()
        {
            while (!tokenSource.Token.IsCancellationRequested)
            {
                if (Console.ReadKey().Key == ConsoleKey.UpArrow)
                {
                    OnUpKey();
                }

                if ((Console.ReadKey().Key == ConsoleKey.DownArrow))
                {
                    OnDownKey();
                }

                if ((Console.ReadKey().Key == ConsoleKey.LeftArrow))
                {
                    OnLeftKey();
                }

                if ((Console.ReadKey().Key == ConsoleKey.RightArrow))
                {
                    OnRightKey();
                }
            }

            return Task.CompletedTask;
        }

        static public void OnDownKey()
        {
            if(OnDownKeyHandler != null)
                OnDownKeyHandler?.Invoke(typeof(InputHandler), EventArgs.Empty);
        }

        static public void OnUpKey()
        {
            if (OnUpKeyHandler != null)
                OnUpKeyHandler?.Invoke(typeof(InputHandler), EventArgs.Empty);
        }

        static public void OnLeftKey()
        {
            if (OnLeftKeyHandler != null)
                OnLeftKeyHandler?.Invoke(typeof(InputHandler), EventArgs.Empty);
        }

        static public void OnRightKey()
        {
            if (OnRightKeyHandler != null)
                OnRightKeyHandler?.Invoke(null, EventArgs.Empty);
        }
    }

}
