using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaZaJivotni
{
    internal class Meat : Food
    {
        public Meat(int quantity)
        {
            base.Quantity = quantity;
        }
    }
}
