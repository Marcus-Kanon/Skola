﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inlämningsuppgift_2___F
{
    static class UserList
    {
        static public List<User> userList = new List<User>();

        static UserList()
        {
            userList.Add(new User());

        }
        

        static public void loadUserList(string file)
        {
            using (StreamReader r = new StreamReader(file + ".json"))
            {
                string json = r.ReadToEnd();
                userList = JsonConvert.DeserializeObject<List<User>>(json);
            }
        }

        static public void saveUserList(string file)
        {
            string json = JsonConvert.SerializeObject(userList.ToArray());

            System.IO.File.WriteAllText(file + ".json", json);
        }

    }
}
