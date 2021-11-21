using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL___Inlämning_1.SQLClient;
using System.Data.SqlClient;
using System.Data;

namespace SQL___Inlämning_1.SQL
{
    public class SqlCommands
    {
        public void CreateDB(SqlConnection connection, string databaseName, string path)
        {

            string str = "CREATE DATABASE " + databaseName + " ON PRIMARY " +
             "(NAME = " + databaseName + ", " +
             "FILENAME = '" + path + "" + databaseName + ".mdf', " +
             "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
             "LOG ON (NAME = " + databaseName + "_Log, " +
             "FILENAME = '" + path + "" + databaseName + ".ldf', " +
             "SIZE = 1MB, " +
             "MAXSIZE = 5MB, " +
             "FILEGROWTH = 10%)";

            using (var q = new SqlCommand(str, connection))
            {
                connection.Open();

                try
                {


                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("EXECUTING: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n" + q.CommandText);

                    q.ExecuteNonQuery();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDatabase was Created Successfully");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (System.Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR:\n" + ex.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
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

        public void CreateTable(SqlConnection connection, string dbName)
        {
            string fileName = "MOCK_DATA.sql";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nTrying to read from " + fileName);
            Console.ForegroundColor = ConsoleColor.White;

            using (StreamReader reader = new(fileName))
            {
                string str = "USE " + dbName + "; ";
                while (!reader.EndOfStream)
                {
                    str += reader.ReadLine();
                }

                connection.Open();

                using (var q = new SqlCommand(str, connection))
                {
                    try
                    {


                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nEXECUTING " + str.Length + " characters of code");
                        Console.ForegroundColor = ConsoleColor.White;

                        q.ExecuteNonQuery();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nTable was created successfully");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (System.Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nERROR:\n" + ex.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
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

        public T ExecuteGenericCommand<T>(SqlConnection connection, string dbName, string str)
        {
            T results;


            using (var q = new SqlCommand(str, connection))
            {
                connection.Open();

                try
                {
                    

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("EXECUTING: " + str);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n" + q.CommandText);

                    q.ExecuteNonQuery();
                }
                catch (System.Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR:\n" + ex.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }




            return results;
        }
    }
}
