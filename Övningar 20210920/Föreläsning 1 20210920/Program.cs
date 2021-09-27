using System;

namespace Föreläsning_1_20210920
{
    class Program
    {
        static void Main(string[] args)
        {
            Dicegame dc = new Dicegame(100);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dc.RollDice());
            }
        }
    }
}
