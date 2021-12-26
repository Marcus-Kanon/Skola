using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryExempel.Interfaces;
using FactoryExempel.Models;

namespace FactoryExempel.Factories
{
    internal class Factory
    {
        public IThing MakeAThing(string name)
        {
            var thing = new Thing { Name = name };
            return thing;
        }
    }
}
