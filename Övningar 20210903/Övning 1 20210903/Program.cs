using System;

namespace Övning_1_20210903
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            while (true)
            {
                Console.WriteLine("Sida A: ");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Sida B: ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("Sida C: ");
                c = double.Parse(Console.ReadLine());

                if (a < 0 || b < 0 || c < 0)
                {
                    Console.WriteLine("Värde lägre än 0\n");
                }
                else
                {
                    Console.WriteLine("Omkretsen är: {0}", a + b + c);
                    break;
                }

                
            }


        }
    }
}