using System;

namespace Övning_1_Basgrupp_20210909
{
    class Program
    {
        static void Main()
        {
            string[] str = {"Mjölk", "3 Mjau - Noga utvald kyckling i sås", "Bananer"};
            double[] dbl = { 17.30, 20, 26, 95};

            // Var for-loop ett krav eller gör han det bara för demo? Tror instruktionerna var oklara och att vi gjorde fel.
            double dblSum = 0;
            for (int i=0; i < str.Length; i++)
            {
                Console.WriteLine("{0} {1}:-", str[i], dbl[i]);
                dblSum += dbl[i];
            }

            foreach(string strTemp in str)
            {
                Console.WriteLine(strTemp);
            }

            foreach(double dblTemp in dbl)
            {
                Console.WriteLine(dblTemp);
            }

           dblSum = 0;
           foreach(double dblTemp in dbl)
           {
                dblSum += dblTemp;
           }
           Console.WriteLine($"Summa: {dblSum}");
        }
    }
}
