using System;
using Föreläsning_1_20210916.Enums;

namespace Föreläsning_1_20210916
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en dag 1-7");
            string input = Console.ReadLine();
            int.TryParse(input, out int day);
            Console.WriteLine((Veckodagar)day);
        }
    }
}
