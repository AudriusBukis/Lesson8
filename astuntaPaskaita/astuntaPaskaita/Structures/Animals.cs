using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaPaskaita
{
    public struct Animals
    {
        public string AnimalName { get; private set; }
        public string AnimalSpecies { get; private set; }

        public Animals(string animalName, string animalSpecies)
        {
            AnimalName = animalName;
            AnimalSpecies = animalSpecies;
        }
    }
}
