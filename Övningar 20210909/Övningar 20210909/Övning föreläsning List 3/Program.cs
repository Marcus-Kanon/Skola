using System;
using System.Collections;

namespace Övning_föreläsning_List_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            arr.Add(5);
            arr.Add("hej");
            arr.Add(7);

            foreach (object obj in arr)
            {
                Console.WriteLine(obj.GetType() + ": ");
                Console.WriteLine(obj);
            }
        }
    }
}
