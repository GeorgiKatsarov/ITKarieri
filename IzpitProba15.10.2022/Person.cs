using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpitProba15._10._2022
{
    public abstract class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length<3 || value.Length>30)
                {
                    throw new ArgumentException("Name should be between 3 and 30 characters!");
                }
                name = value;
            }
            
        }
        public int Age
        {
            get { return age; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentException("Age must be 0 or positive!");
                }
                age = value; 
            }
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return $"Name: {this.Name}"+"\n"+$"Age: {this.Age}";
        }
    }
}
