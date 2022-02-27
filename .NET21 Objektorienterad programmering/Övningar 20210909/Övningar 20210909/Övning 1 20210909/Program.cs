using System;
using System.Collections.Generic;
using System.Linq;

namespace Övning_1_20210909
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new();
            Random rnd = new Random();

            for(int i =0; i<10; i++)
            {
                numList.Add(rnd.Next(1, 1000));
            }

            foreach(int num in numList)
            {
                Console.WriteLine("numList[x]={0}", num);
            }

            Console.WriteLine("Summa: " + numList.Sum());
            Console.WriteLine("Medelvärde: " + numList.Sum()/numList.Count);

        }
    }
}
