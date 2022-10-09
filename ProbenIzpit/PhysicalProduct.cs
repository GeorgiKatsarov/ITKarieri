using System;

namespace ShoppingSystem
{
	public class PhysicalProduct:Product
	{
		private double weight;
		public double Weight { get { return weight; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Weight can not be less or equal to 0!");
                }

                this.weight = value;
            }
        }
        public PhysicalProduct(string name, double price, double weight): base(name, price)
        {
            
            this.Weight = weight;
        }
        public override string ToString()
        {
            return base.ToString()+"\n"+$"Weight: {this.Weight}";
        }
    }
}

