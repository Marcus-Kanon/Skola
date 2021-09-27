using System;
using System.Collections.Generic;

namespace Övning_föreläsning_List_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namn = new List<string>()
            {
                "Macke",
                "Ronny",
                "Conny",
                "Johnny",
                "Pony"
            };

            int id = namn.IndexOf("Pony");
            namn.RemoveAt(id);

            Console.WriteLine(namn[0]);

            foreach (var str in namn)
            {
                Console.WriteLine(str);
            }
        }
    }
}
