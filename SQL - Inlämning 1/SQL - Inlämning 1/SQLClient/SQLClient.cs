using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL___Inlämning_1
{
    internal class SQLClient
    {
        public SqlConnection? C { get; set; }

        public void Login()
        {
            LoginXMLReader XmlReader = new();
            LoginDetails? LoginDetails = XmlReader.Read();

            if (!XmlReader.IsNull(LoginDetails))
            {
                Console.WriteLine("Tring to Login with: ");
                Console.WriteLine("Username: " + LoginDetails.name);
                Console.WriteLine("Password: " + LoginDetails.password);
                Console.WriteLine("Server: " + LoginDetails.server);

                C = new(
                    "Server=" + LoginDetails.server + ";" +
                    "User id=" + LoginDetails.name + ";" +
                    "Password=" + LoginDetails.password + ";" +
                    "Integrated security=SSPI;" +
                    "database=master"
                    );

                if (C is null)
                {
                    Console.WriteLine("Failed to login");
                }
            }
            else
            {
                Console.WriteLine("Error reading login-data");
            }
        }
    }
}
