using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerIzpit
{
    public class Residence : Building
    {
        public Residence(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
        {
            if (name.EndsWith("Residence") == false)
            {
                throw new ArgumentException("Name of Residence buildings should end on Residence!");
            }
        }
    }
}
