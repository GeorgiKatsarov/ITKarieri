using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal : IMakeNoise, IMakeTrick
    {
        private string name;
        private int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("My name is {0}. I am {1} old.", name, age);
            
        }

        public virtual void MakeTrick()
        {
            Console.WriteLine("Look at my trick!");
        }
    }
}
