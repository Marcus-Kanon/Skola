using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Databasövning_1
{
    class Databas
    {
        public string ConnectionString { get; set; } = @"Data Source=.\SQLExpress;Integrated Security=true;database={0}";
        public string DatabaseName { get; set; } = "CarRental";

        public static void Saker()
        {
            // Console.WriteLine("Test");
            // string query = "";
        }

        public static void Executerrrr<T>(string q, params T[] parameter)
        {
            ExecuteNonQuery();
        }

        public static void GetDataTable(string q)
        {

        }
    }
}
