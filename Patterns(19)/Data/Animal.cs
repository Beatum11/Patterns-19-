using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_19_.Data
{
    public interface IAnimal
    {
       public string Name { get; set; }

       public string Type { get; } 

        public string ShowNote()
        {
            return $"{Name} | {Type} ";
        }
    }
}
