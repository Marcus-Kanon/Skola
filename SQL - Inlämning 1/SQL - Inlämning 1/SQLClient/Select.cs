using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL___Inlämning_1.SQLClient
{
    internal class Select
    {


        public void Start()
        {

            Console.WriteLine("*Reading logins from login.xml*\n");

            LoginXMLReader reader = new LoginXMLReader();
            reader.Read();

            Console.WriteLine("Select one of following logins\n");

            for (int i = 0; i < reader.logins.Count; i++)
            {
                string passLength = "";

                for (int p = 0; p < reader.logins[i].Password.Length; p++)
                {
                    passLength += "*";
                }

                Console.WriteLine(i + 1 + ". Name: " + reader.logins[i].Name + "\n\tServer: " + reader.logins[i].Server + "\n\tPassword: " + passLength);
            }

            Console.WriteLine("\nOr type 0 to edit logins");

            int.TryParse(Console.ReadLine(), out int select);

            SQLClient.LoginDetails.Name = reader.logins[select - 1].Name;
            SQLClient.LoginDetails.Server = reader.logins[select - 1].Server;
            SQLClient.LoginDetails.Password = reader.logins[select - 1].Password;

            Console.WriteLine("Selected login:\n\t" + SQLClient.LoginDetails.Name + "\n\t" + SQLClient.LoginDetails.Server);
        }
    }
}
