using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml
{
    public class Emp : Person, Interface1
    {
        private string department;
        private double salary;

        public string Departament
        {
            get { return department; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("value", "Departament must be  atleast 2 digits long");
                    department = value;
                }
                
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("value", "Salary must be a positive number");
                }
                salary = value;

            }
        }

        public Emp(string adress, int age, string city, string name, string deartment, double salary)
            : base(adress, age, city, name)
        {
             Departament =  deartment ;
             Salary = salary;
        }

        public void DoSomeWork()
        {
            Console.WriteLine($"Adress: {Adress}, Age: {Age}, City: {City}, Name: {Name},  Department {Departament},  Salary {Salary}");
        }
    }
}
