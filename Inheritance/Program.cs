using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ivan", 10, "SU Kiril i Metodii", 4);
            student1.GiveInfoAboutStudent();
            student1.Age = 12;
            student1.School = "telerik";
            student1.Grade = 6;
            student1.GiveInfoAboutStudent();

        }
    }
}
