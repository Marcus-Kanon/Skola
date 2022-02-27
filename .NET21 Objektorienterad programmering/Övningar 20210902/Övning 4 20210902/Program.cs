using System;

namespace Övning_4_20210902
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tjabba, ska vi ta reda på hur många bokstäver dina mellannamn har? Skriv hela ditt namn:");

            String namn = Console.ReadLine();
            String[] mellanNamn = namn.Split(" ");

            Console.WriteLine("\n");

            foreach (String s in mellanNamn)
            {
                Console.WriteLine("{0} Har {1} bokstäver", s, s.Length);
            }
            
        }
    }
}
