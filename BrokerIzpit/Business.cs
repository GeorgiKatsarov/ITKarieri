using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerIzpit
{
    public class Business : Building
    {
        public Business(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
        {
            if (name.EndsWith("Business") == false)
            {
                throw new ArgumentException("Name of Business buildings should end on Business!");
            }
        }
    }
}
