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
                try
                {
                    if (value.Length < 2)
                    {
                        Console.WriteLine("Departament must be  atleast 2 digits long");
                        throw new Exception();

                    }
                    department = value;
                }
                catch (Exception)
                {

                    string name = Console.ReadLine();
                    while (name.Length < 2)
                    {
                        Console.WriteLine("Departament must be  atleast 2 digits long");
                        name = Console.ReadLine();
                    }
                    this.department = name;
                }
                
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Salary must be a positive number");
                        throw new Exception();
                    }
                    salary = value;
                }
                catch (Exception)
                {

                    double name = double.Parse(Console.ReadLine());
                    while (name < 0)
                    {
                        Console.WriteLine("Age must be a positive number");
                        name = double.Parse(Console.ReadLine());
                    }
                    this.salary = name;
                }
                

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
