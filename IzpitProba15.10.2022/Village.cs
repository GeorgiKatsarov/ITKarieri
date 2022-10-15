using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpitProba15._10._2022
{
    public class Village
    {
        private string name;
        private string location;
        private int resource;
        private List<Peasent> peasents;
        public string Name
        {
            get { return name; }
            set {
                if (value.Length < 2 || value.Length > 40)
                {
                    throw new ArgumentException("Name should be between 2 and 40 characters");
                }
                name = value;
            }
        }
        public string Location
        {
            get { return location; }
            set
            {
                if (value.Length < 3 || value.Length > 35)
                {
                    throw new ArgumentException("Location should be between 3 and 35 characters");
                }
                location = value;
            }
        }
        public int Resource
        {
            get { return resource; }
            set { resource = value; }
        }
        public Village(string name, string locatiomn)
        {
            this.name = name;
            this.location = locatiomn;
            peasents = new List<Peasent>();
        }
        public void AddPeasant(Peasent peasent)
        {
            peasents.Add(peasent);
        }
        public int PassDay()
        {
            int sumProductivity = 0;
            foreach (var item in peasents)
            {
                sumProductivity += item.Productivity;
            }
            resource += sumProductivity;
            return sumProductivity;
        }

        public List<Peasent> KillPeasants(int count)
        {
            if (count < peasents.Count)
            {
                List<Peasent> killedPeasants = new List<Peasent>();
                for (int i = 0; i < count; i++)
                {
                    var a = peasents.First();
                    peasents.Remove(a);
                    killedPeasants.Add(a);
                }

                return killedPeasants;
            }
            else
            {
                return peasents;
            }
        }
        public override string ToString()
        {
            return $"Village - {Name} ({Location}) \n Resources - {Resource} \n Peasants {peasents.Count} \n {string.Join("\n", peasents)}";
        }
    }
}
