using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit2._15._10._2022
{
    public class Food : Product
    {
        public Food(string name, int quantity, double deliverPrice, double percentageMarkup) : base(name, quantity, deliverPrice, percentageMarkup)
        {
            if (percentageMarkup>100)
            {
                throw new ArgumentException();
            }
        }
    }
}
