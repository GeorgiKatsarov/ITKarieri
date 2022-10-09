using System;

namespace ShoppingSystem
{
    public class ServiceProduct : Product
    {
        private double time;
        public double Time
        {
            get { return time; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Time can not be less or equal to 0!");
                }

                this.time = value;
            }
        }
        public ServiceProduct(string name, double price, double Time) : base(name, price)
        {

            this.Time = Time;
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + $"Time: {this.Time}";
        }
    }
}