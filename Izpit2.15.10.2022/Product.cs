using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit2._15._10._2022
{
    public abstract class Product
    {
        private string name;
        private int quantity;
        private double deliverPrice;
        private double percantageMarkup;
        private double finalPrice;

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
        public int Quantity
        {
            get { return quantity; }
            set 
            {
                if (value<=0)
                {
                    throw new ArgumentException();
                }
                quantity = value; }
        }
        public double DeliverPrice
        {
            get { return deliverPrice; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                deliverPrice = value;
            }
        }

        public double PercantageMarkup
        {
            get { return percantageMarkup; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                percantageMarkup = value;
            }
        }
        public double FinalPrice
        {
            get { return deliverPrice+deliverPrice*percantageMarkup/100; }
        }
        public Product(string name, int quantity, double deliverPrice, double percentageMarkup)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.DeliverPrice = deliverPrice;
            this.PercantageMarkup=percentageMarkup;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Product: {this.Name} <{this.Quantity}>");
            sb.AppendLine($"****Deliver Price: {this.DeliverPrice}");
            sb.AppendLine($"****Percentage Markup: {this.PercantageMarkup}");
            sb.AppendLine($"****Final Price: {this.FinalPrice}");
            return sb.ToString();
        }



    }
}
