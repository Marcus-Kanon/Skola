using System;

namespace Övning_2_20210906
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal=0;;

            while (tal < 1 || tal > 80)
            {
                Console.WriteLine("Välj ett tal mellan 1 och 80: ");
                tal = int.Parse(Console.ReadLine());
            }

            Console.CursorTop = 10;

            do
            {
                Console.CursorLeft=tal;
                Console.CursorVisible = false;
                Console.Write("o");

                tal--;

                System.Threading.Thread.Sleep(10);

                Console.Clear();

            } while (tal>0);

        }
    }
}
