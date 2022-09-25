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
                try
                {
                    if (value.Length < 2)
                    {
                        Console.WriteLine("The name must be atleast 2 letters long");
                        throw new Exception();
                    };
                    this.name = value;
                }
                catch (Exception)
                {
                    string name = Console.ReadLine();
                    while (name.Length<2)
                    {
                        Console.WriteLine("The name must be atleast 2 letters long");
                        name = Console.ReadLine();
                    }
                    this.name = name;
                }
                
                
            }
            
        }
        public string City
        { get { return city; }
            set {
                try
                {
                    if (value.Length < 2)
                    {
                       Console.WriteLine("The city must be atleast 2 letters long");
                        throw new Exception();
                    }
                    city = value;
                }
                catch (Exception)
                {
                    string name = Console.ReadLine();
                    while (name.Length < 2)
                    {
                        Console.WriteLine("The city must be atleast 2 letters long");
                        name = Console.ReadLine();
                    }
                    city = name;
                     
                }
                
            } 
        }
        public int Age { 
            get { return age; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Age must be a positive number");
                        throw new Exception();
                    }
                    age = value;
                }
                catch (Exception)
                {
                    int name = int.Parse(Console.ReadLine());
                    while (name < 0)
                    {
                        Console.WriteLine("Age must be a positive number");
                        name = int.Parse(Console.ReadLine());
                    }
                    this.age = name;
                    
                }
                
            } 
        
        
        }
        public string Adress { get { return adress; } set {
                try
                {
                    if (value.Length < 2)
                    {
                        Console.WriteLine("The adress must be atleast 2 letters long");
                        throw new Exception();
                    }
                    adress = value; ;
                }
                catch (Exception)
                {

                    string name = Console.ReadLine();
                    while (name.Length < 2)
                    {
                        Console.WriteLine("The adress must be atleast 2 letters long");
                        name = Console.ReadLine();
                    }
                    this.adress = name; ;
                }
                
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
