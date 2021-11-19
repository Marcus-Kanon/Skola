using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL___Inlämning_1.SQL
{
    public class SqlCommands
    {
        public void CreateDB(SqlConnection connection, string databaseName, string path)
        {
            path = "C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\";

            string str = "CREATE DATABASE @DATABASENAME ON PRIMARY " +
             "(NAME = @DATABASENAME, " +
             "FILENAME = ' @DATABASENAME .mdf', " +
             "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
             "LOG ON (NAME = DATABASENAME _Log, " +
             "FILENAME = '@PATH @DATABASENAME .ldf', " +
             "SIZE = 1MB, " +
             "MAXSIZE = 5MB, " +
             "FILEGROWTH = 10%)";

            SqlCommand q = new(str, connection);
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter()
                {
                    ParameterName = "@DATABSENAME",
                    Value = databaseName
                },
                new SqlParameter()
                {
                    ParameterName = "@PATH",
                    Value = path
                }
            };

            for (int i = 0; i < parameters.Length; i++)
            {
                q.Parameters.Add(parameters[i]);
            }

            try
            {
                connection.Open();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("EXECUTING: \n\n\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(q.CommandText);

                q.ExecuteNonQuery();
                Console.WriteLine("Database was Created Successfully");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
