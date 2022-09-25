using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml
{
    public class Customer : Person, Interface1
    {
        private string custemerID;
        private string shippingAddress;

        public string CustemerID
        {
            get { return custemerID; }
            set
            {
                try
                {
                    if (value.Length == 4)
                    {
                        custemerID = value;
                    }
                    else
                    {
                        Console.WriteLine("Customer ID must be 4 digits long");
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    string name = Console.ReadLine();
                    while (name.Length == 4)
                    {
                        Console.WriteLine("Customer ID must be 4 digits long");
                        name = Console.ReadLine();
                    }
                    this.custemerID = name; ;
                }
                
            } }

        public string ShippingAddress
        {
            get { return shippingAddress; }
            set
            {
                try
                {
                    if (value.Length < 2)
                    {
                        Console.WriteLine("Shipping address must be atleast 2 letteres long");
                        throw new Exception();
                    }
                    shippingAddress = value;
                }
                catch (Exception)
                {

                    string name = Console.ReadLine();
                    while (name.Length < 2)
                    {
                        Console.WriteLine("Shipping address must be atleast 2 letteres long");
                        name = Console.ReadLine();
                    }
                    this.shippingAddress = name; ;
                }
                
               
            }
        }

        public Customer(string adress, int age, string city, string name, string custmerID, string shipingAddress)
            :base( adress, age, city, name)
        {
            CustemerID = custmerID;
            ShippingAddress = shipingAddress;
        }

        public void DoSomeWork()
        {
            Console.WriteLine($"Adress: {Adress}, Age: {Age}, City: {City}, Name: {Name}, Customer ID {CustemerID}, Shipping Address {ShippingAddress}");
        }
    }
}
