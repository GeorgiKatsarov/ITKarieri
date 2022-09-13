using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("Sharo", 4);
            Cat c = new Cat("Maca", 2);
            

            d.MakeNoise();
            d.MakeTrick();
            c.MakeNoise();
            c.MakeTrick();
        }
    }
}
