using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpitProba15._10._2022
{
    public class Controller
    {
        private int attacs = 0;
        private List<Village> villages = new List<Village>();
        private List<Rebel> rebels = new List<Rebel>();
        int harm = 0;
        public string ProcessVillageCommand(List<string> args)
        {
            Village village = new Village(args[0], args[1]) ;
            villages.Add(village);
            return $"Created village {args[0]}" ;
        }

        public string ProcessSettleCommand(List<string> args)
        {
            Peasent peasent = new Peasent(args[0], int.Parse(args[1]), int.Parse(args[2]));
            foreach (var item in villages)
            {
                if ((item.Name).Equals(args[3]))
                {
                    item.AddPeasant(peasent);
                }
            }
            return $"Setteled Peasent {args[0]} in Village {args[3]}";
        }

        public string ProcessRebelCommand(List<string> args)
        {
            Rebel rebel = new Rebel(args[0], int.Parse(args[1]), int.Parse(args[2]));
            rebels.Add(rebel);
            return $"Rebel {args[0]} Joined the Gang";
        }

        public string ProcessDayCommand(List<string> args)
        {
            int nBefore=0;
            int nAfter=0;
            foreach (var item in villages)
            {
                if ((item.Name).Equals(args[0]))
                {
                    nBefore = item.Resource;
                    item.PassDay();
                    nAfter = item.Resource;
                }
            }
            int nDiff = nAfter - nBefore;
            return $"Village {args[0]} resource increased with {nDiff}";
        }

        public string ProcessAttackCommand(List<string> args)
        {
            Village village = villages.Where(x => x.Name == args[1]).FirstOrDefault()!;
            int rebelsCount = int.Parse(args[0]);
            attacs++;
            if (rebels.Count == 0)
            {
                return "No rebels to perform aid";
            }
            for (int i = 0; i < rebelsCount; i++)
            {
                harm += rebels[i].Harm;
            }
            village.Resource -= harm;
            var a = village.KillPeasants(rebelsCount / 2);
            int sharm = harm;
            harm = 0;
            return $"Village {village.Name} lost {sharm} resources and {a.Count} peasents";


        }
        public string ProcessInfoCommand(List<string> args)
        {
            StringBuilder sb = new StringBuilder();
            
            if (args[0].Equals("Rebel"))
            {
                sb.Append("Rebels:");
                foreach (var item in rebels)
                {
                    sb.AppendLine(item.ToString()); 
                }
            }
            else
            {
                sb.Append("Villages:");
                foreach (var item in villages)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }

        public string ProcessEndCommand()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Villages: {villages.Count}");
            sb.AppendLine($"Rebels: {rebels.Count}");
            sb.AppendLine($"Attacs on village: {attacs}");
            return sb.ToString();
            
        }
    }
}
