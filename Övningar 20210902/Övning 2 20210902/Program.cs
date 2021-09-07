using System;

namespace Övning_2_20210902
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, vad är din ålder?");

            int dogeAge = int.Parse(System.Console.ReadLine())*7;

            Console.WriteLine("Du är {0} i hund år. Hejdå!\n", dogeAge);
        }
    }
}
