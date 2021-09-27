using System;
using System.Collections.Generic;

namespace Övning_3_20210909
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new() {
            "Per",
            "Pia",
            "Pontus",
            "Amanda",
            "Lök-Ragnar"};

            names.Sort();

            foreach(string name in names)
            {
                Console.WriteLine(name);

            }



        }
    }
}
