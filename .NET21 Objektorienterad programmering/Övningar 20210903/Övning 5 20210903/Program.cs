using System;

namespace Övning_5_20210903
{
    class Program
    {
        static void Main(string[] args)
        {
            int bollPositionX = 0;
            int bollPositionY = 0;
            int bollSpeedX = 1;
            int bollSpeedY = 1;

            int bollPositionMaxX = 100;
            int bollPositionMaxY = 20;

            int bollPositionMinX = 1;
            int bollPositionMinY = 1;

            Console.CursorVisible = false;
            Random rnd = new Random();

            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(bollPositionX, bollPositionY);
                Console.WriteLine("o");
                Console.ForegroundColor=(ConsoleColor)rnd.Next(0, 15);
                //Console.BackgroundColor= (ConsoleColor)rnd.Next(0, 15);

                bollPositionX += bollSpeedX;
                bollPositionY += bollSpeedY;

                if (bollPositionX > bollPositionMaxX)
                    bollSpeedX *= -1;

                if (bollPositionY > bollPositionMaxY)
                    bollSpeedY *= -1;

                if (bollPositionX < bollPositionMinX)
                    bollSpeedX *= -1;

                if (bollPositionY < bollPositionMinY)
                    bollSpeedY *= -1;

                System.Threading.Thread.Sleep(1);
            }

        }
    }
}
