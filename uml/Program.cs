using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Student student = new Student("Ivan Vazov 2", -19, "Plovdiv", "I", "000000000000", "Bio");
            Emp emp = new Emp("Ivan Vazov 2", 19, "Plovdiv", "Ivan", "Tech", 50000.3);
            Customer customer = new Customer("Ivan Vazov 2", 19, "Plovdiv", "Ivan", "1010", "Ivan Vazov 2");
            
            student.DoSomeWork();
            emp.DoSomeWork();
            customer.DoSomeWork();
        }
    }
}