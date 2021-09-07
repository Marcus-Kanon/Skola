using System;

namespace Inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo=500; //Pengar man startar med
            int antalTarningar = 3; //Välj hur många tärningar det ska vara här (testa ett löjligt högt tal)
            int satsning = 0;
            int tal = 0;
            int[] slumpTal = new int[antalTarningar]; //Lägger tärningskasten i en array ifall man min vill kommer åt dom efter loopen
            int antalLika=0;
            string spelaIgen;
            bool firstTime=true;
            Random rnd = new Random();

            Console.WriteLine("Välkommen till spelautomaten där du spelar bort dina hårt intjänade pengar! \n\nDu har {0} kr", saldo);

            while (saldo >= 50)
            {
                if (!firstTime) //kollar om det är första rundan
                {
                    Console.WriteLine("Spela igen? (ja/nej)");
                    spelaIgen=Console.ReadLine();

                    if (spelaIgen=="nej")
                    {
                        break;
                    }
                    else if (spelaIgen!="ja")
                    {
                        Console.WriteLine("Felaktigt svar.");

                        continue;
                    }

                }

                if (satsning == 0)
                {
                    Console.WriteLine("\nHur mycket vill du satsa?");
                    int.TryParse(Console.ReadLine(), out satsning);
                }

                if (satsning > saldo)
                {
                    Console.WriteLine("Du kan inte satsa mer än vad du har.\n");
                    satsning = 0;
                    firstTime = true; //Låtsas att det är första rundan för att slippa frågan "Spela igen?"

                    continue;
                }

                if (satsning < 50)
                {
                    Console.WriteLine("Du får minst satsa 50 kr {0}\n", satsning);
                    satsning = 0;
                    firstTime = true; //Låtsas att det är första rundan för att slippa frågan "Spela igen?"

                    continue;
                }

                Console.WriteLine("Vilket tal väljer du (1-6)?");
                tal = int.Parse(Console.ReadLine());

                if(tal>6 || tal<1)
                {
                    Console.WriteLine("Välj ett tal mellan 1 och 6\n");

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
                    Console.WriteLine("\n{0} rätt! Du vinner {1} kr", antalLika, (antalLika + 1) * satsning); //(antalLika+1)*satsning omvandlar antal rätt till vinst i kronor
                    saldo += (antalLika + 1) * satsning;
                }
                else
                {
                    Console.WriteLine("Du gissade fel!");
                }

                Console.WriteLine("\n---Saldo: {0}---\n", saldo);

                antalLika = 0;
                satsning = 0;
                firstTime = false;
            }

            if (saldo < 50)
            {
                Console.WriteLine("Du har för lite pengar för att spela. Hejdå! Tack för pengarna.");
            }
            else
            {
                Console.WriteLine("\nHejdå och välkommen åter.");
            }
        }
    }
}
