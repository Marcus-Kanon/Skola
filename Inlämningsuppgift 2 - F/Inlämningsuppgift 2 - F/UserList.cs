using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2___F
{
    static class UserList
    {
        static List<User> userList = new List<User>();

        static public void loadUserList()
        {
            
        }

        static public void saveUserList()
        {
            string json = JsonConvert.SerializeObject(userList, Formatting.Indented);
        }

    }
}
