using System;

namespace Övningar_20210902
{
    class Program1
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ange längd för sida A: ");
            double a = Double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Ange längd för sida B: ");
            double b = Double.Parse(System.Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            System.Console.WriteLine("------------------ \nTriangelns Omkrets är: {0}\n", a + b + c);
            System.Console.WriteLine("Triangelns area är: {0}\n", a + b / 2);


        }
    }
}