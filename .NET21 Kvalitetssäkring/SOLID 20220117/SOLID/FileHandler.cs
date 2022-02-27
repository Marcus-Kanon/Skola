using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class FileHandler
    {
        public string FileName { get; set; } = "";

        public string Load() => File.Exists(FileName) ? File.ReadAllText(FileName) : "";
    }
}
