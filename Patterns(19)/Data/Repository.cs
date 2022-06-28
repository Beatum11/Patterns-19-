using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_19_.Data
{
    internal class Repository
    {
        public List<IAnimal> animals;

        public Repository() => animals = new List<IAnimal>();

    }
}
