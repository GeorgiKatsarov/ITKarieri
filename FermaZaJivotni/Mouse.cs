using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaZaJivotni
{
    internal class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
        {
            base.AnimalName = name;
            base.AnimalWeight = weight;
            base.LivingRegion = livingRegion;
            
        }
    }
}
