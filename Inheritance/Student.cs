using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : Person
    {
        private string school;
        private int grade;

        public string School
        {
            get { return school; }
            set { school = value; }
        }
        public int Grade
        { 
            get { return grade; }
            set { grade = value; }
        }
        public Student(string personName, int personAge, string school, int grade)
           
        {
            
            base.Name = personName;
            base.Age = personAge;
            this.School = school;
            this.Grade = grade;
        }

        public void GiveInfoAboutStudent()
        {
            Console.WriteLine($"Student {base.Name}, Age {base.Age}, School {this.School}, Grade {this.Grade} "); 
        }

    }
}
