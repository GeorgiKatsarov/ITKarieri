using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerIzpit
{
    public class Broker
    {
        List<Building> buildings = new List<Building>();
        private string name;
        private int age;
        private string city;
        private double bonus;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Equals(String.Empty) || value.Equals(null))
                {
                    throw new ArgumentException("Broker name must not be null or empty!");
                }
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16 || value > 70)
                {
                    throw new ArgumentException("Broker's age cannot be less than 16 or above 70!");
                }
                age = value;
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (value.Equals(String.Empty) || value.Equals(null))
                {
                    throw new ArgumentException("City must not be null or empty!");
                }
                city = value;
            }
        }

        public Broker(string name, int age, string city)
        {
            this.name = name;
            this.age = age;
            this.city = city;
        }
       public  double ReceiveBonus(Building building)
        {
            buildings.Add(building);
            double bonus = 0;
            bonus = building.RentAmount * 2 * building.Stars / 100;
            this.bonus = bonus;
            return bonus;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Broker: {Name} <{Age}>\n ****Location: { City}\n****Bonus: {bonus}");
            foreach (var item in buildings)
            {
                sb.AppendLine();
                for (int i = 0; i < item.Stars; i++)
                {
                    sb.Append("*");
                }
                sb.Append($" {item.Name}");
            }
            return sb.ToString();
        }



    }
}
