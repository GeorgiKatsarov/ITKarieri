using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    public class Product
    {
        private string name;

        private double price;

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
             set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Name should be between 3 and 30 characters!");
                }

                this.name = value;
            }
        }

        public double Price
        {
            get { return this.price; }
             set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price should be 0 or positive!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}" + Environment.NewLine +
                   $"Price: {this.Price:f2}\n" ;
        }
    }
}
