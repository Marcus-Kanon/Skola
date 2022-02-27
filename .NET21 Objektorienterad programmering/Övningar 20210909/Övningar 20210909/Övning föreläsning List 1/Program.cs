using System;
using System.Collections.Generic;

namespace Övning_föreläsning_List_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 32, 54, 67, 12 };
            List<int> myList=new List<int>(intArray);
            myList.Add(1);
            myList.Add(12);
            myList.Add(31);
            myList.Add(33);
            myList.Add(54);


            foreach(var num in myList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
