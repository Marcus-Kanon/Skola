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
        static string containter = "";
        public static void Print(this string msg, ConsoleColor color, int x, int y, ConsoleColor backgroundColor=ConsoleColor.Black)
        {


            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = color;
            Console.Write(msg);
            Console.ResetColor();

        }

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern SafeFileHandle CreateFile(
            string fileName,
            [MarshalAs(UnmanagedType.U4)] uint fileAccess,
            [MarshalAs(UnmanagedType.U4)] uint fileShare,
            IntPtr securityAttributes,
            [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
            [MarshalAs(UnmanagedType.U4)] int flags,
            IntPtr template);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteConsoleOutputW(
            SafeFileHandle hConsoleOutput,
            CharInfo[] lpBuffer,
            Coord dwBufferSize,
            Coord dwBufferCoord,
            ref SmallRect lpWriteRegion);

        [StructLayout(LayoutKind.Sequential)]
        public struct Coord
        {
            public short X;
            public short Y;

            public Coord(short X, short Y)
            {
                this.X = X;
                this.Y = Y;
            }
        };

        [StructLayout(LayoutKind.Explicit)]
        public struct CharUnion
        {
            [FieldOffset(0)] public ushort UnicodeChar;
            [FieldOffset(0)] public byte AsciiChar;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct CharInfo
        {
            [FieldOffset(0)] public CharUnion Char;
            [FieldOffset(2)] public short Attributes;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SmallRect
        {
            public short Left;
            public short Top;
            public short Right;
            public short Bottom;
        }


        [STAThread]
        public static void Start(string msg, int x=0, int y=0)
        {
            SafeFileHandle h = CreateFile("CONOUT$", 0x40000000, 2, IntPtr.Zero, FileMode.Open, 0, IntPtr.Zero);

            if (!h.IsInvalid)
            {
                CharInfo[] buf = new CharInfo[80 * 25];
                SmallRect rect = new SmallRect() { Left = 0, Top = 0, Right = 80, Bottom = 25 };
                short attribute = 0;

                for (int i = 0; i < msg.Length; i++)
                {
                    buf[i].Attributes = (short)(attribute | (1));
                    buf[i].Char.UnicodeChar = msg[i];
                }

                

                bool b = WriteConsoleOutputW(h, buf,
                new Coord() { X = 80, Y = 25 },
                new Coord() { X = 0, Y = 0 },
                ref rect);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
