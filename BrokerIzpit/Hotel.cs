﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerIzpit
{
    public class Hotel : Building
    {
        public Hotel(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
        {
            if (name.EndsWith("Hotel")==false)
            {
                throw new ArgumentException("Name of hotel buildings should end on Hotel!");
            }
        }
    }
}
