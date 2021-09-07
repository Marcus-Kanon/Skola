using System;

namespace Övning_3_20210906
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Tal: ");
            int tal = 0;
            int resultat = 0;

            int.TryParse(Console.ReadLine(), out tal);

            for (int i = 0; i < tal; i++)
            {
                resultat += tal;
            }

            Console.WriteLine("Resultat: {0}", resultat);

        }
    }
}
