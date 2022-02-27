using System;

namespace Övning_3_20210903
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int G;
            Random rnd = new Random();
            int R = rnd.Next(0, 100);

            Console.WriteLine("Gissa numret!");

            while (true)
            {
                G = int.Parse(Console.ReadLine());
                c++;
                
                if (G==R)
                {
                    Console.WriteLine("Du gissade rätt efter {0} gånger!", c);
                    break;
                }
                else if (G>R)
                {
                    Console.WriteLine("För högt");
                }
                else if (G<R)
                {
                    Console.WriteLine("För lågt");
                }
            }


        }
    }
}
