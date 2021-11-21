using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL___Inlämning_1.SqlCommander
{
    internal class SqlCommandMenu
    {
        List<String> MenuItems = new List<String>();
        int Choice = 0;

        public SqlCommandMenu()
        {
            MenuItems.Add("Hur många olika länder finns representerade?");

            MenuItems.Add("Är alla username och password unika?");

            MenuItems.Add("Hur många är från Norden respektive Skandinavien ?");

            MenuItems.Add("Vilket är det vanligaste landet?");

            MenuItems.Add("Lista de 10 första användarna vars efternamn börjar på bokstaven");

            MenuItems.Add("Visa alla användare vars för - och efternamn har samma begynnelsebokstav");
        }

        public void Show()
        {
            for (int i = 0; i < MenuItems.Count; i++)
            {
                Console.WriteLine($"{i}. " + MenuItems[i]);
            }

            while (!int.TryParse(Console.ReadLine(), out Choice) || Choice<1 || Choice > MenuItems.Count)
            {
                Console.WriteLine("Ogiltligt val");
            }

            ExecuteSqlCommands(Choice);
        }

        public void ExecuteSqlCommands(int choice)
        {
            switch (choice)
            {
                case 0:
                default:
                    Show();
                    break;
            }
        }
    }
}
