using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL___Inlämning_1
{
    internal class DatabaseHandler
    {
        SqlConnection? Connection;

        public void Login()
        {
            XmlReader XmlReader = new();
            SqlLoginDetails? LoginDetails = XmlReader.Read();

            if (!XmlReader.IsNull(LoginDetails))
            {
                Console.WriteLine("Tring to Login with: ");
                Console.WriteLine("Username: " + LoginDetails.name);
                Console.WriteLine("Password: " + LoginDetails.password);
                Console.WriteLine("Server: " + LoginDetails.server);

                Connection = new(
                    "Server=" + LoginDetails.server + ";" +
                    "User id=" + LoginDetails.name + ";" +
                    "Password=" + LoginDetails.password + ";" +
                    "Integrated security=SSPI;" +
                    "database=master"
                    );

                if (Connection is null)
                {
                    Console.WriteLine("Failed to login");
                }
            }
            else
            {
                Console.WriteLine("Error reading login-data");
            }

        }

        public void CreateDB(string database)
        {

            string str = "CREATE DATABASE DataTest ON PRIMARY " +
             "(NAME = TestData, " +
             "FILENAME = 'C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\" + database + ".mdf', " +
             "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
             "LOG ON (NAME = MyDatabase_Log, " +
             "FILENAME = 'C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\" + database + ".ldf', " +
             "SIZE = 1MB, " +
             "MAXSIZE = 5MB, " +
             "FILEGROWTH = 10%)";

            SqlCommand myCommand = new(str, Connection);
            try
            {
                Connection.Open();
                myCommand.ExecuteNonQuery();
                Console.WriteLine("DataBase was Created Successfully");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }
    }
}
