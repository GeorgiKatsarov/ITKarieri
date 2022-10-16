using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit2._15._10._2022
{
    public class Store
    {
        private string name;
        private string type;
        private double revenue;
        List<Product> products = new List<Product>();
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Equals(null) || value.Equals(string.Empty))
                {
                    throw new ArgumentException();
                }
                name = value;
            }
        }
        public string Type
        {
            get { return type; }
            set 
            {
                if (value.Equals(null) || value.Equals(string.Empty))
                {
                    throw new ArgumentException();
                }
                type = value;
            }
        }
        public Store(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
        public bool ReceiveProduct(Product product)
        {
            if (products.Contains(product))
            {
                return false;
            }   
            else
            {
                products.Add(product);
                return true;
            }
        }
       public bool SellProduct(string name, int quantity)
        {
            foreach (var item in products)
            {
                if (item.Name.Equals(name) && item.Quantity >= quantity)
                {
                    item.Quantity-= quantity;
                    revenue += item.FinalPrice * quantity;
                    if (item.Quantity==0)
                    {
                        products.Remove(item);
                    }
                    return true;
                }
                
            }
            return false;
        }
        public Product GetProduct(string name)
        {
            foreach (var item in products)
            {
                if (item.Name.Equals(name))
                {
                    return item;
                }
            }
            return null;
        }
        public double GetRevenue()
        {
            return revenue;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Store: {Name} <{Type}>");
            sb.AppendLine($"****Available products: <{products.Count()}>");
            foreach (var item in products)
            {
                sb.AppendLine($"****** {item.Name} ({item.Quantity})");
            }
            sb.AppendLine($"****Revenue: <{revenue:f2}BGN>");
            return sb.ToString();
        }

    }
}
