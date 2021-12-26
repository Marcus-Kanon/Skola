using FactoryExempel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExempel.Models
{
    internal class Thing : IThing
    {
        public string Name { get; set; } = "";
    }
}
