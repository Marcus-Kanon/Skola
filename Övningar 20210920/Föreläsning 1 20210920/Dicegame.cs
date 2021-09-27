using System;

namespace Föreläsning_1_20210920
{
    internal class Dicegame
    {
        private int value;
        private int max = 6;

        public Dicegame(int max)
        {
            this.max = max;
        }
        public Dicegame()
        {
            max = 6;
        }

        public int RollDice()
        {
            Random rnd = new Random();
            value = rnd.Next(1, rnd.Next(1, max + 1));
            return value;
        }
    }
}