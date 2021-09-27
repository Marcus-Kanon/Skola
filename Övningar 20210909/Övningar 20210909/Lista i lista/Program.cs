using System;
using System.Collections.Generic;

namespace Lista_i_lista
{

    public class MinClass : List<MinClass>
    {
        public int x = 0;
        public int y = 0;
        public string b { set; get; }

        public MinClass(int numX, int numY)
        {
            x = numX;
            y = numY;
        }

        public void blockMaker(int nX, int nY)
        {
            for (int x = 0; x < nX; x++)
            {
                this.Add(new MinClass(x, 0));

                for (int y = 0; y < nY; y++)
                {
                    this[x].Add(new MinClass(x, y));
                }
            }
        }

        public void doEachBlock(Action<int, int, int> callFunc)
        {
            int lowestCountY = this[0].Count;
            int countX = this.Count;

            for (int y = 0; y < lowestCountY; y++)//Göra en error class för när y>lowestCount
            {
                for (int x = 0; x < countX; x++)
                {
                    if (this[x].Count < lowestCountY && y == 0)
                        lowestCountY = this[x].Count;

                    callFunc(x, y, countX);

                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MinClass blocks = new MinClass(0, 0);

            blocks.blockMaker(15, 40);

            blocks.doEachBlock((x, y, CountX) =>
            {
                Console.Write($"|{x},{y}|");

                if (x == CountX - 1)
                    Console.WriteLine("");
            });

            blocks[0].RemoveAt(1);

            blocks.doEachBlock((x, y, CountX) =>
            {
                Console.Write($"|{x},{y}|");

                if (x == CountX - 1)
                    Console.WriteLine("");
            });
        }
    }
}
