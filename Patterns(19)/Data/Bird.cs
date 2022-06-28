using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_19_.Data
{
    public class Bird : IAnimal
    {
        public string Name { get; set; }    

        public string Type
        {
            get
            {
                return "Птица";
            }
        }

        public Bird (string name) => Name = name;

    }
}
