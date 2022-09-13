using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedostigNaHrana
{
    public class Citizen : IBuyer
    {
        public int Food { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }
        public string Birthday { get; set; }

        public void BuyFood()
        {
            this.Food+=10;
        }

        public Citizen(string name, int age, int id,string birthday )
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.Birthday = birthday;
            this.Food = 0;
        }
    }
}
