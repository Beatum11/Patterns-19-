using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_19_.Data
{
    public class AnimalFactory
    {
        

        public IAnimal Create(string animalType, string animalName)
        {

            switch (animalType)
            {
                case "Mammal":
                    return new Mammal(animalName);

                case "Bird":
                    return new Bird(animalName);
                    
                case "Amphibian":
                    return new Amphibian(animalName);

                default:
                    return null;
            }
        }



    }
}
