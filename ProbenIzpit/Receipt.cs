using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSystem
{
	public class Receipt
	{
		private string customerName;
        private List<Product> products;
		public string CustomerName
        {
			get { return customerName; }
			set {
                
            
                    if (value.Length < 2 || value.Length > 40)
                    {
                        throw new ArgumentException("Customer Name should be between 2 and 40 characters!");
                    }

                    this.customerName = value;
                }
        }
        public Receipt(string customerN)
        {
            products = new List<Product>();
            this.customerName = customerN;
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public double GetPriceAll()
        {
            double price = 0;
            foreach (var item in products)
            {
                price += item.Price;
            }
            return price;
        }
        public string GetAllProducts()
        {
            StringBuilder s = new StringBuilder();
            foreach (var item in products)
            {
                s.AppendLine(item.ToString());   
            }
            return s.ToString();
        }
        public override string ToString()
        {
            return $"Receipt of {CustomerName}\n Total price: {GetPriceAll():f2}\n Products: {GetAllProducts()}\n";
        }
    }

}
