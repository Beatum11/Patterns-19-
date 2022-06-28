using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_19_.Data
{
    public class Amphibian : IAnimal
    {
        public string Name { get; set; }   
        
        public string Type
        {
            get
            {
                return "Земноводное";
            }
        }

        public Amphibian(string name) => Name = name;
    }
}
