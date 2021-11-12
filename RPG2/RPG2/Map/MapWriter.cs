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
        static int[] map = new int[100];
        
        static MapWriter()
        {
            Random rnd = new();
            for (int i = 0; i < 100; i++)
            {
                map[i] = rnd.Next(0,7);
            }
        }

        public static void Draw(int x)
        {
            Console.Clear();

            for (int row = 0; row < 17; row++)
            {
                
                for (int col = Player.X-10; col < Player.X+10; col++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int written = row * 5;
                        var currentBit = MapBits.mapBits[map[col]];
                        int playerRow = 13;
                        int playerHeight = 3;
                        int playerWidth = 3;

                        if(col == Player.X && row >= playerRow-1 && row < playerRow+playerHeight && i < playerWidth)
                        {
                            if(row >= playerRow)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write(Player.Drawing[(row - playerRow) * playerWidth + i].ToString());
                            }
                            else if(i==0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($"HP: {Player.Hp}");
                            }
                            
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
    }
}
