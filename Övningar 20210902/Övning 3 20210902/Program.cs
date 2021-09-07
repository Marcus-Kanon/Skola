using System;

namespace Övning_3_20210902
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Vad heter du?");

            String namn = Console.ReadLine();

            Console.WriteLine("Du heter {0} och har {1} tecken i ditt namn. Välkommen åter!", namn, namn.Length);

        }
    }
}
