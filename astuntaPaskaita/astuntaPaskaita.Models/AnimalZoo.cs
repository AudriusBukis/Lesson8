using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaPaskaita
{
    public struct AnimalZoo
    {
        public string ZooName { get; private set; }

        public string ZooAdresse { get; private set; }

        public List<Animals> Animals { get; set;}

        public AnimalZoo(string zooName, string zooAdresse) : this()
        {
            ZooName = zooName;
            ZooAdresse = zooAdresse;
            Animals = new List<Animals>();
        }

        public int AnimalCount()
        {
            return Animals.Count;
        }
        public void AddAnimal(Animals animal) 
        {
            if (string.IsNullOrEmpty(animal.AnimalName) || string.IsNullOrEmpty(animal.AnimalSpecies))
            {
                throw new ArgumentException("Animal name ar Species are empty");
            }
            Animals.Add(animal);
        }

        public int CountSpecies(string species)
        {
            return Animals.Where(x => x.AnimalSpecies == species).Count();
        }
    }
}
