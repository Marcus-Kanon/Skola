using System;
using System.Collections.Generic;
using System.Linq;

namespace Övning_2_20210909
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> sides = new();
            double area, circum;

            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Ange sida #{0}: ", i+1);
                sides.Add(double.Parse(Console.ReadLine()));
            }

            sides.Sort();
            circum=sides.Sum();
            area = (circum - sides[sides.Count - 1])/2;

            Console.WriteLine("Omkrets: {0}\nArea: {1}", circum, area);
        }
    }
}
