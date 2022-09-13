using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal
    {
        public Cat(string name, int age)
        : base(name, age) {
            
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Meow!");
            base.MakeNoise();
        }

        public override void MakeTrick()
        {
            base.MakeTrick();
            Console.WriteLine("No trick for you! I'm too lazy!");
        }
    }
}
