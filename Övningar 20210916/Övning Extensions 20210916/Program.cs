using System;

namespace Övning_Extensions_20210916
{
    static class MyExtensions
    {
        public static int Nummerologic(this int value)
        {
            //Omvandla talet till text
            string val = value.ToString();
            //Nollställ slutsumman
            int total = 0;
            for (int i = 0; i < val.Length; i++)
            {
                //Addera summan med varje siffra i talet
                total += int.Parse(val[i].ToString());
            }
            //Om slutsumman är större än 9 och inte lika med 11 eller 22
            //så räkna ihop det nya resultatet.
            if (total > 9 && total != 11 && total != 22)
                total = Nummerologic(total);
            return total;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
