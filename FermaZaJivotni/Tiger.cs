using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaZaJivotni
{
    internal class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion)
        {
            base.AnimalName = name;
            base.AnimalWeight = weight;
            base.LivingRegion = livingRegion;

        }
    }
}
