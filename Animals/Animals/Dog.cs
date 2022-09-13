using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(string name, int age)
        : base(name, age) {
            
        }
        public void MakeNoise()
        {
            Console.WriteLine("Woof!");
            base.MakeNoise();
        }

        public void MakeTrick()
        {
            base.MakeTrick();
            Console.WriteLine("Hold my paw, human!");
        }
    }
}
