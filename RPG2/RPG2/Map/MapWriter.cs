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
                map[i] = rnd.Next(0,2);
            }
        }

        public static void Draw(int x)
        {
            x = 25;
            for (int row = 0; row < 17; row++)
            {
                
                for (int col = x-10; col < x+10; col++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int written = row * 5;
                        string str = MapBits.mapBits[map[col]][written + i].ToString();

                        Console.Write(str);
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
