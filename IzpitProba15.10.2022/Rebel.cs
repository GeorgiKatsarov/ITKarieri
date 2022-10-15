using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpitProba15._10._2022
{
    public class Rebel : Person
    {
        private int harm;
        public int Harm
        {
            get { return harm; }
            set { 
                if (value < 0)
                {
                    throw new ArgumentException("Harm should be greater than 0!");
                }
                harm = value; 
            }
        }



        public Rebel(string name, int age, int harm) : base(name, age)
        {
            if (age>50)
            {
                throw new ArgumentException("Age should be less or equel to 50!");
            }
            this.harm = harm;
        }
        public override string ToString()
        {
            return base.ToString()+"\n"+$"Harm: {this.Harm}";
        }
    }
}
