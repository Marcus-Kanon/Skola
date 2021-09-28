using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace Inlämningsuppgift_2___F
{
    static class userList
    {
        static private int _selectedMonth = 1;
        static public BindingList<user> users = new BindingList<user>();

        static public int selectedMonth
        {
            get { return _selectedMonth; }
            set {
                _selectedMonth = value;
                if (value < 1)
                    _selectedMonth = 12;
                if(value>12)
                    _selectedMonth = 1;
                }
        }

        static userList()
        {
            

        }
        

        static public void loadUserList(string file)
        {
            using (StreamReader r = new StreamReader(file + ".json"))
            {
                string json = r.ReadToEnd();
                users = JsonConvert.DeserializeObject<BindingList<user>>(json);
            }
        }

        static public void saveUserList(string file)
        {
            string json = JsonConvert.SerializeObject(users.ToArray());

            System.IO.File.WriteAllText(file + ".json", json);
        }

        static public IEnumerable<user> filterUsersByMonthBorn()
        {
            IEnumerable<user> results = users.Where(q => q.birthday.Month == selectedMonth).ToList();

            return results;
        }


    }
}
