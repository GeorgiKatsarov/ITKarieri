using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml
{
    public abstract class Person 
    {
        private string adress;
        private int age;
        private string city;
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("value", "The name must be atleast 2 letters long");
                };
                this.name = value;
            }
            
        }
        public string City
        { get { return city; }
            set {
                if (value.Length<2)
                {
                    throw new ArgumentException("value", "The city must be atleast 2 letters long");
                }
                city = value;
            } 
        }
        public int Age { 
            get { return age; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("value", "Age must be a positive number");
                }  
                age = value;
            } 
        
        
        }
        public string Adress { get { return adress; } set {
                if (value.Length < 2)
                {
                    throw new ArgumentException("value", "The adress must be atleast 2 letters long");
                }
                adress = value; ;
            } }

        public Person( string adress, int age, string city, string name)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
            this.Adress = adress;
        }
    }
}
