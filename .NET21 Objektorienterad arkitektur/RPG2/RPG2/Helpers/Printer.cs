using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.Helpers
{
    public static class Printer
    {
        public static void Print(this string msg, ConsoleColor color, int x=0, int y=0, ConsoleColor backgroundColor=ConsoleColor.Black)
        {
            Console.CursorVisible = false;

            if(x != 0 && y != 0)
            {
                Console.CursorLeft = x;
                Console.CursorTop = y;
            }

            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = color;
            Console.Write(msg);
            Console.ResetColor();

        }
    }
}
