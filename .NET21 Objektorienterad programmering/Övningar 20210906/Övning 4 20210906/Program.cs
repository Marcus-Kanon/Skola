using System;

namespace Övning_4_20210906
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Namn: ");

            String namn = Console.ReadLine();

            foreach(char s in namn)
            {
                Console.WriteLine(s);
            }
        }
    }
}
