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
        static public BindingList<user> users = new BindingList<user>();

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

    }
}
