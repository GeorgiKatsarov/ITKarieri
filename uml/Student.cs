using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml
{
    public class Student : Person, Interface1
    {
        private string rolleNumber;
        private string studyingClass;

        public string RolleNumber
        {
            get { return rolleNumber; }
            set
            {
                try
                {
                     if (value.Length == 10)
                     {
                        rolleNumber = value;
                     }
                else
                {
                    Console.WriteLine("Roll Number must be 10 digits long");
                    throw new Exception();
                }
                }
                catch (Exception)
                {
                    string name = Console.ReadLine();
                    while (name.Length == 10)
                    {
                        Console.WriteLine("Roll Number must be 10 digits long");
                        name = Console.ReadLine();
                    }
                    this.rolleNumber = name; ;
                    
                }
               
            }
        }

        public string StudyingClass
        {
            get { return studyingClass; }
            set
            {
                try
                {
                    if (value.Length < 2)
                    {
                        Console.WriteLine("Studying class must be atleast 2 letteres long");
                        throw new Exception();
                    }
                    studyingClass = value;
                }
                catch (Exception)
                {

                    string name = Console.ReadLine();
                    while (name.Length < 2)
                    {
                        Console.WriteLine("Studying class must be atleast 2 letteres long");
                        name = Console.ReadLine();
                    }
                    this.studyingClass = name; ;
                }
                

            }
        }

        public Student(string adress, int age, string city, string name, string rollNumber, string studyingClas)
            : base(adress, age, city, name)
        {
            RolleNumber = rollNumber;
            StudyingClass = studyingClas;
        }

        public void DoSomeWork()
        {
            Console.WriteLine($"Adress: {Adress}, Age: {Age}, City: {City}, Name: {Name}, Rolle number {RolleNumber},  Studying Class {StudyingClass}");
        }
    }
}
