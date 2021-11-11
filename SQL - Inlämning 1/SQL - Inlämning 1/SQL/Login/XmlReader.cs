using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SQL___Inlämning_1
{
    internal class XmlReader
    {
        public SqlLoginDetails? Read()
        {
            SqlLoginDetails? login = new();
            XmlSerializer xmls = new XmlSerializer(typeof(SqlLoginDetails));

            using (var sr = new StreamReader("login.xml"))
            {
                login = xmls.Deserialize(sr) as SqlLoginDetails;
            }

            return login;
        }
        
        public bool IsNull(SqlLoginDetails details)
        {
            if (details is null || details.name == null || details.password == null || details.server == null)
                return true;
            else
                return false;
        }
    }
}
