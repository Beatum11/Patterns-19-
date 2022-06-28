using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns_19_.Data;
using System.IO;

namespace Patterns_19_.Models
{
    internal class Model
    {
        public void SaveTxt(List<IAnimal> animals)
        {
            string s = @"animals.txt";

            foreach (var animal in animals)
            {
                File.AppendAllText(s, animal.ShowNote());
            }
        }

        public void SaveDocx(List<IAnimal> animals)
        {
            string s = @"animals.docx";

            foreach (var animal in animals)
            {
                File.AppendAllText(s, animal.ShowNote());
            }
        }




    }
}
