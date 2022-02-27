using System;

namespace Övning_1_20210906
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            int memory = 0;

            while (int.TryParse(Console.ReadLine(), out value) && value>=0)
            {
                memory += value;
            }

            Console.WriteLine("Summa: {0}", memory);
        }

    }
}
