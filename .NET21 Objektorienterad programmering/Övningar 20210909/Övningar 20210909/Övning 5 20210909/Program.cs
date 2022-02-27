using System;
using System.Collections;

namespace Övning_5_20210909
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add(5);
            arrList.Add("hej");
            arrList.Add(10);
            arrList.Add(2);
            arrList.Add("mhm");
            arrList.Add(5.9);

            foreach(object obj in arrList)
            {
                if (obj is int)
                    Console.WriteLine((int)obj*2);
                if (obj is double)
                    Console.WriteLine((double)obj);
                if (obj is string)
                    Console.WriteLine((string)obj);
            }



        }
    }
}
