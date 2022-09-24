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
                if (value.Length == 10)
                {
                    rolleNumber = value;
                }
                else
                {
                    throw new ArgumentException("value", "Roll Number must be 10 digits long");
                }
            }
        }

        public string StudyingClass
        {
            get { return studyingClass; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("value", "Studying class must be atleast 2 letteres long");
                }
                studyingClass = value;

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
