using System;
using System.Collections.Generic;
using System.Linq;

namespace Övning_1_20210913
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountDetails account=new AccountDetails();
            string user="", password="";
            int val = 0;

            do
            {
                Console.WriteLine("Vad är ditt användarnamn?");
                user = Console.ReadLine();
                Console.WriteLine("Vad är ditt lösenord?");
                password = Console.ReadLine();
            } while (!account.getAccountDetails(user, password));

            Console.WriteLine("Namn: " + account.accountName);
            Console.WriteLine("Kontonummer: " + account.accountNumber);
            Console.WriteLine("Belopp: " + account.accountBalance + "\n");

            do
            {
                Console.WriteLine(" - Meny - ");
                Console.WriteLine("1) Byt namn");
                Console.WriteLine("2) Byt lösenord");

                int.TryParse(Console.ReadLine(), out val);
            } while (val <= 0);

            if (val == 1)
            {
                Console.WriteLine("Skriv ditt namn: ");
                account.accountName=Console.ReadLine();
                Console.WriteLine("Namn ändrat");
            }
            else if (val==2)
            {
                Console.WriteLine("Skriv ditt lösenord: ");
                account.setPassword(Console.ReadLine());
                Console.WriteLine("Lösenord ändrat");
            }

            account.updateAccountDetails();

        }

        public void getAccountInfo(string accountName)
        {

        }

    }
}
