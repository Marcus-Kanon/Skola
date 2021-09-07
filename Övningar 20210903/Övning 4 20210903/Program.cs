using System;

namespace Övning_4_20210903
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, hund, katt;
            Console.WriteLine("Tjo! Vad är din ålder?");

            a = int.Parse(Console.ReadLine());
            hund = 16 * (int)Math.Log(a) + 31;


            if (a == 1)
            {
                katt = 14;
            }
            else if (a==2)
            {
                katt = 24;
            }
            else
            {
                katt = 24 + (a - 2) * 4;
            }

            if(a<=0)
            {
                Console.WriteLine("Sluta, du är inte {0} år", a);
            }
            else
            {
                Console.WriteLine("Din hundålder är: {0}", hund);
                Console.WriteLine("Din kattålder är: {0}", katt);
            }


        }
    }
}
