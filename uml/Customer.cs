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
                if (value.Length == 4)
                {
                    custemerID = value;
                }
                else
                {
                    throw new ArgumentException("value", "Customer ID must be 4 digits long");
                }
            } }

        public string ShippingAddress
        {
            get { return shippingAddress; }
            set
            {
                if (value.Length < 2)
                {
                   throw new ArgumentException("value", "Shipping address must be atleast 2 letteres long");
                }
                shippingAddress = value;
               
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
