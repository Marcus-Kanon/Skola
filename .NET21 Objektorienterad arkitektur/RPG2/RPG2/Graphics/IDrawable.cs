using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.Graphics
{
    public interface IDrawable
    {
        public int ID { get; set; }
        public int X { get; set; }
        public int DrawRow { get; set; }
        public int DrawHeight { get; set; }
        public int DrawWidth { get; set; }
        public string Drawing { get; set; }
        public List<string> Text { get; set; }
    }
}
