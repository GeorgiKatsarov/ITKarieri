using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedostigNaHrana
{
    internal interface IBuyer
    {
        public int Food { get; set; }
        public abstract void BuyFood();
    }
}
