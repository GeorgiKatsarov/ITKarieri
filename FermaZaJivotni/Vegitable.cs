using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaZaJivotni
{
    internal class Vegetable : Food
    {
        public Vegetable(int quantity)
        {
            base.Quantity = quantity;
        }
    }
}
