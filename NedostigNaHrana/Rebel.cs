using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedostigNaHrana
{
    public class Rebel : IBuyer
    {
        private int food;
        private string name;
        private int age;
        private string group;
        public int Food { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }


        public void BuyFood()
        {
            this.Food += 5;
        }
        public Rebel(string name, int age, string Group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = Group;
            this.Food = 0;
        }
    }
}
