using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerIzpit
{
    public class Company
    {
        private List<Building> buildings;
        private List<Broker> brokers;
        private string name;
        public List<Building> Buildings
        {
            get { return buildings; }
            set { buildings = value; }
        }
        public List<Broker> Brokers
        {
            get { return brokers; }
             set { brokers = value; }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Equals(String.Empty) || value.Equals(null))
                {
                    throw new ArgumentException("Company name must not be null or empty!");
                }
                name = value;
            }
        }
        public Company(string name)
        {
            this.name = name;
            buildings = new List<Building>();
            brokers = new List<Broker>();

        }
        void AddBroker(Broker broker)
        {
            if (brokers.Contains(broker)==false)
            {
                brokers.Add(broker);
            }
        }
        void AddBuilding(Building building)
        {
            if (buildings.Contains(building) == false)
            {
                buildings.Add(building);
            }
        }
        Broker GetBrokerByName(string name)
        {
            foreach (var item in brokers)
            {
                if (item.Name.Equals(name))
                {
                    return item;
                }
            }
            return null;
        }
        Building GetBuildingByName(string name)
        {
            foreach (var item in buildings)
            {
                if (item.Name.Equals(name))
                {
                    return item;
                }
            }
            return null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Company: {Name}");
            sb.AppendLine($"##Brokers: {brokers.Count}");
            foreach (var item in brokers)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"##Buildings – {buildings.Count}");
            foreach (var item in buildings)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
