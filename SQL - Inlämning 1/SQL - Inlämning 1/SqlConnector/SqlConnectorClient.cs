using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL___Inlämning_1.SQLClient
{
    internal static class SqlConnectorClient
    {
        public static SqlConnection? C { get; set; }
        public static LoginDetails LoginInfo { get; set; } = new LoginDetails();

        public static void GenerateConnection()
        {
            LoginXMLReader XmlReader = new();
            List<LoginDetails> logins = XmlReader.Read();

            if (!XmlReader.IsNull(LoginInfo))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nBuilding connecting string with:");


                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\tUsername: " + LoginInfo.Name);
                Console.WriteLine("\tServer: " + LoginInfo.Server + "\n\n");
                

                string cStr = "Server=" + LoginInfo.Server + ";" +
                                "User id=" + LoginInfo.Name + ";" +
                                "Password=" + LoginInfo.Password + ";" +
                                "Integrated security=SSPI;" +
                                "database=master";

                Console.WriteLine("\tConnection String=" + cStr);

                Console.ForegroundColor = ConsoleColor.White;

                C = new("Server=" + LoginInfo.Server + "; " +
                    "User id=" + LoginInfo.Name + "; " +
                    "Password=" + LoginInfo.Password + "; " +
                    "Integrated security=SSPI; " +
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
            Console.WriteLine("\nManaged to generate connection string\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void AddLogin()
        {

        }
    }
}
