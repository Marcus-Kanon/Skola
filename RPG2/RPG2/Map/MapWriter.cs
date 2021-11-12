using RPG2.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    static public class MapWriter
    {
        static public int mapSize { get; set; } = 20;

        static int[] map = new int[mapSize];
        static int col = 0;
        static int Col
        {
            get
            {
                return col;
            }
            set
            {
                if (value < 0)
                    value = 0;
                col = value;
            }
        }
            
        
        static MapWriter()
        {
            Random rnd = new();
            for (int i = 0; i < mapSize; i++)
            {
                map[i] = rnd.Next(0,7);
            }
        }

        public static void Draw(int x)
        {
            Console.Clear();

            for (int row = 0; row < 17; row++)
            {
                
                for (Col = Player.X-10; (Col < Player.X+10 || Col < 20) && Col < mapSize; Col++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int written = row * 5;
                        var currentBit = MapBits.mapBits[map[Col]];

                        if(checkToDrawPlayer(Col, row, i))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(Player.Drawing[(row - Player.DrawRow) * Player.DrawWidth + i].ToString());
                        }
                        else
                        {
                            string str = currentBit.Drawing[written + i].ToString();

                            Console.ForegroundColor = currentBit.Color;
                            Console.Write(str);
                        }

                        
                    }
                }
                Console.WriteLine();
            }
            
        }

        static bool checkToDrawPlayer(int col, int row, int i)
        {
            if (col == Player.X && row >= Player.DrawRow && row < Player.DrawRow + Player.DrawHeight && i < Player.DrawWidth)
            {
                return true;
            }

            return false;
        }
    }
}
