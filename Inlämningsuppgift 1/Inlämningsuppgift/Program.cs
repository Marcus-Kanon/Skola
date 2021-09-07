using System;

namespace Inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo=500; //Pengar man startar med
            int antalTarningar = 3;
            int satsning=0;
            int tal;
            Random rnd = new Random();
            int[] slumpTal = new int[antalTarningar];
            int antalLika=0;

            Console.WriteLine("Välkommer till spelautomaten där du spelar bort dina hårt intjänade pengar! \n\nDu har {0} kr\n", saldo);

            while (saldo >= 50)
            {
                if (satsning == 0)
                {
                    Console.WriteLine("Hur mycket vill du satsa?");
                    satsning = int.Parse(Console.ReadLine());
                }

                if (satsning > saldo)
                {
                    Console.WriteLine("Du kan inte satsa mer än vad du har.\n");
                    satsning = 0;

                    continue;
                }

                if (satsning < 50)
                {
                    Console.WriteLine("Du får minst satsa 50 kr\n");
                    satsning = 0;

                    continue;
                }

                Console.WriteLine("Vilket tal väljer du (1-6)?");
                tal = int.Parse(Console.ReadLine());

                if(tal>6 || tal<1)
                {
                    Console.WriteLine("Välj ett tal mellan 1 och 6");

                    continue;
                }

                Console.WriteLine("");

                saldo -= satsning;

                for (int i = 0; i < antalTarningar; ++i)
                {
                    slumpTal[i] = rnd.Next(1, 7);
                    Console.WriteLine("Tärning #{0}: {1}", i + 1, slumpTal[i]);

                    if (slumpTal[i] == tal)
                    {
                        antalLika++;
                    }
                }

                if (antalLika > 0)
                { 
                    Console.WriteLine("\n{0} rätt! Du vinner {1} kr", antalLika, (antalLika + 1) * satsning); //(antalLika+1)*satsning imvandlar antal rätt till vinst i pengar
                    saldo += (antalLika + 1) * satsning;
                }
                else
                {
                    Console.WriteLine("Du gissade fel!");
                }

                Console.WriteLine("Saldo: {0}\n", saldo);

                antalLika = 0;
                satsning = 0;
            }

            Console.WriteLine("Du har för lite pengar för att spela. Hejdå! Tack för pengarna.");


        }
    }
}
