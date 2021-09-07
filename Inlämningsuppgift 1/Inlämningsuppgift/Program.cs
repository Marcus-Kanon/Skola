using System;

namespace Inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int dinero=500; //Pengar man startar med
            int antalTarningar = 3;
            int satsning;
            int tal;

            Random rnd = new Random();
            int[] slumpTal = new int[antalTarningar];

            Console.WriteLine("Välkommer till spelautomaten där du spelar bort dina hårt tjänade pengar! \n Du har {0} kr", dinero);

            while(dinero>=50)
            {
                Console.WriteLine("Hur mycket vill du satsa?");
                satsning=int.Parse(Console.ReadLine());
                tal=int.Parse(Console.ReadLine());


            }


        }
    }
}
