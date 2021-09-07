using System;

namespace Övning_2_20210903
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Goddag! Vad är din ålder?");
            a=int.Parse(Console.ReadLine());

            if(a >= 15)
            {
                Console.WriteLine("Får köra EU-moppe");
            }
            else
            {
                Console.WriteLine("Får inte köra EU-moppe");
            }


            if (a >= 18)
            {
                Console.WriteLine("Får köra bil");
            }
            else
            {
                Console.WriteLine("Får inte köra bil");
            }


            if (a >= 21)
            {
                Console.WriteLine("Får köra lastbil");
            }
            else
            {
                Console.WriteLine("Får inte köra lastbil");
            }


            if (a >= 24)
            {
                Console.WriteLine("Får köra buss");
            }
            else
            {
                Console.WriteLine("Får inte köra buss");
            }

        }
    }
}
