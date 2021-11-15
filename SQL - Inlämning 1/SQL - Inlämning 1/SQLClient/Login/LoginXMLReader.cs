using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SQL___Inlämning_1
{
    internal class LoginXMLReader
    {
        public LoginDetails? Read()
        {
            LoginDetails? login = new();
            XmlSerializer xmls = new XmlSerializer(typeof(LoginDetails));

            using (var sr = new StreamReader("login.xml"))
            {
                login = xmls.Deserialize(sr) as LoginDetails;
            }

            return login;
        }
        
        public bool IsNull(LoginDetails details)
        {
            if (details is null || details.name == null || details.password == null || details.server == null)
                return true;
            else
                return false;
        }
    }
}
