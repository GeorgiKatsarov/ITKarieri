using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevozniSredstva 
{
    internal class Car : Abstract
    {
        public Car(double liters, double km)
        {
            base.LitersFuel = liters;
            base.FuelEficency = km;
            
        }

        public override bool DriveCar(double distance)
        {
            return base.DriveCar(distance);
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters);
        }
    }
}
