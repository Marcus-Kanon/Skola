using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL___Inlämning_1.SQLClient
{
    internal static class SQLClient
    {
        public static SqlConnection? C { get; set; }
        public static LoginDetails LoginDetails { get; set; } = new LoginDetails();

        public static void GenerateConnection()
        {
            LoginXMLReader XmlReader = new();
            List<LoginDetails> logins = XmlReader.Read();

            if (!XmlReader.IsNull(LoginDetails))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nBuilding connecting string with:");


                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\tUsername: " + LoginDetails.Name);
                Console.WriteLine("\tServer: " + LoginDetails.Server);
                Console.ForegroundColor = ConsoleColor.White;

                C = new(
                    "Server=" + LoginDetails.Server + ";" +
                    "User id=" + LoginDetails.Name + ";" +
                    "Password=" + LoginDetails.Password + ";" +
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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nManaged to generate connection string");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void AddLogin()
        {

        }
    }
}
