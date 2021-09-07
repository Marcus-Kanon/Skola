﻿using System;

namespace Inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo=500; //Pengar man startar med
            int antalTarningar = 3;
            int satsning;
            int tal;
            Random rnd = new Random();
            int[] slumpTal = new int[antalTarningar];
            int antalLika=0;

            Console.WriteLine("Välkommer till spelautomaten där du spelar bort dina hårt intjänade pengar! \n\nDu har {0} kr\n", saldo);

            while (saldo >= 50)
            {
                Console.WriteLine("Hur mycket vill du satsa?");
                satsning = int.Parse(Console.ReadLine());
                saldo -= satsning;

                Console.WriteLine("Vilket tal väljer du?");
                tal = int.Parse(Console.ReadLine());

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
                    Console.WriteLine("{0} rätt! Du vinner {1}", antalLika, (antalLika + 1) * satsning); //(antalLika+1)*satsning imvandlar antal rätt till vinst i pengar
                    saldo += (antalLika + 1) * satsning;
                }
                else
                {
                    Console.WriteLine("Du gissade fel!");
                }

                Console.WriteLine("Saldo: {0}", saldo);

                antalLika = 0;
            }


        }
    }
}
