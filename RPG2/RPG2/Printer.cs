using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    public static class Printer
    {
        public static void Print(this string msg, ConsoleColor color, int x, int y, ConsoleColor backgroundColor=ConsoleColor.Black)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = color;
            Console.Write(msg);
            Console.ResetColor();

        }
    }
}
