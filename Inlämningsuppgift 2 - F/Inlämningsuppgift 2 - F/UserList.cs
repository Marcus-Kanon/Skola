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
    static class UserList
    {
        static public BindingList<User> userList = new BindingList<User>();

        static UserList()
        {
            

        }
        

        static public void loadUserList(string file)
        {
            using (StreamReader r = new StreamReader(file + ".json"))
            {
                string json = r.ReadToEnd();
                userList = JsonConvert.DeserializeObject<BindingList<User>>(json);
            }
        }

        static public void saveUserList(string file)
        {
            string json = JsonConvert.SerializeObject(userList.ToArray());

            System.IO.File.WriteAllText(file + ".json", json);
        }

    }
}
