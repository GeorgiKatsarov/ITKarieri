using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
        public int Grade { get; set; }

        public Student(string name, int age, string school, int grade)
        {
            Name = name;
            Age = age;
            School = school;
            Grade = grade;
        }

        public string ReturnInfo()
        {
            return $"Name: {Name}, Age: {Age}, School: {School}, Grade: {Grade} \n \n";
        }
    }
}
