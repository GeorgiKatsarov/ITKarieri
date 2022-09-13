using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaZaJivotni
{
    internal class Cat : Feline
    {
        public string Breed { get; set; }

        public Cat(string name, double weight, string livingRegion, string breed)
        {
            base.AnimalName = name;
            base.AnimalWeight = weight;
            base.LivingRegion = livingRegion;
            this.Breed = breed;
        }
    }
}
