using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevozniSredstva
{
    public abstract class Abstract
    {
        public double LitersFuel { get; set; }
        public double FuelEficency { get; set; }
       

        public virtual bool DriveCar( double distance)
        {
            if (LitersFuel/FuelEficency > distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual void Refuel( double liters)
        {
            LitersFuel += liters;
        }
        
    }
}
