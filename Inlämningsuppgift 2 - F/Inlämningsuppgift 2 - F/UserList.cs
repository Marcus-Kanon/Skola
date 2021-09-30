using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Text;

namespace Inlämningsuppgift_2___F
{
    static class userList
    {
        static private int _selectedMonth = DateTime.Now.Month;
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
        

        static public bool loadUserList(string file)
        {
            if (File.Exists(file + ".json"))
            {
                using (StreamReader r = new StreamReader(file + ".json"))
                {
                    string json = r.ReadToEnd();
                    users = JsonConvert.DeserializeObject<BindingList<user>>(json);
                    
                }

                return true;
            }
            else
            {
                users = new BindingList<user>();

                MessageBox.Show("Couldn't find " + file + ".json");

                return false;
            }
        }

        static public void saveUserList(ref Stream stream)
        {
            string json = JsonConvert.SerializeObject(users.ToArray());
            //System.IO.File.WriteAllText(stream. + ".json", json);
            //File.WriteAllBytes(stream)
            stream.Write(Encoding.ASCII.GetBytes(json));

        }

        static public IEnumerable<user> filterUsers(Func<user, bool> q)
        {
            IEnumerable<user> results = users.Where(q).ToList();

            return results;
        }

        static public string getBirthdaysString(int month)
        {
            IEnumerable<user> users = filterUsers(q => q.birthday.Month == selectedMonth);
            string str = "";

            foreach (var user in users)
            {
                str += user.firstName + " " + user.lastName + "\t\t\t" + user.birthday.ToShortDateString() + "\r\n";
            }

            return str;
        }


    }
}
