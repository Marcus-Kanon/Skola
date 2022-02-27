using System;
using System.Collections.Generic;

namespace Föreläsning_3_Dictionary_20210916
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            names.Add("Batman", "Bruce Wayne");
            names.Add("Superman", "Clark Kent");
            names.Add("Catwoman", "Celina Kyle");
            names.Add("Equalizer", "Denzel Washington");

            //names.Add("Catwoman", "Celina Kyle");

            foreach (var item in names)
            {
                Console.WriteLine(item.Key + "is " + item.Value);
            }
        }
    }
}
