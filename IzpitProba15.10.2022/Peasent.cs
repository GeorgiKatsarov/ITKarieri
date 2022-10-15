using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpitProba15._10._2022
{
    public class Peasent : Person
    {
        private int productivity;
        public int Productivity
        {
            get { return productivity; }
            set 
            {
                if (productivity>=0)
                {
                    throw new ArgumentException("Productivity cannot be less or equel to 0!");
                }
                productivity = value; 
            }
        }
        public Peasent(string name, int age, int productiv) : base(name, age)
        {
            productivity = productiv;
            if (age > 110)
            {
                throw new ArgumentException("Age cannot be greater than 110!");
            }
        }
        public override string ToString()
        {
            return base.ToString()+"\n"+$"Productivity: {this.Productivity}";
        }
    }
}
