using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerIzpit
{
    public abstract class Building
    {

        private string name;
        private string city;
        private int stars;
        private double rentAmount;
        private bool isAvailable;
        public string Name
        {
            get { return name; }
            set 
            {
                if (value.Equals(String.Empty)|| value.Equals(null))
                {
                    throw new ArgumentException("Building name must not be null or empty!");
                }
                name = value; 
            }
        }
        public string City
        {
            get { return city; }
            set {
                if (value.Equals(String.Empty) || value.Equals(null))
                {
                    throw new ArgumentException("City must not be null or empty!");
                }
                city = value; }
        }
        public int Stars
        {
            get { return stars; }
            set
            {
                if (value<0 || value>5)
                {
                    throw new ArgumentException("Stars cannot be less than 0 or above 5!");
                }
                stars = value; }
        }
        public double RentAmount
        {
            get { return rentAmount; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Rent amount cannot be less or equal to 0!");
                } 
                rentAmount = value; }
        }
        private bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }
        public Building(string name, string city, int stars, double rentAmount)
        {
            this.name = name;
            this.city = city;
            this.stars = stars;
            this.rentAmount = rentAmount;
        }
        public override string ToString()
        {
            return $"****Building: {Name} < Stars >\n ****Location: {City}\n****RentAmount: {RentAmount}\n****Is Available: {IsAvailable}"
;
        }

    }
}
