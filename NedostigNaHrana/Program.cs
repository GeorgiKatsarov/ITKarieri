
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedostigNaHrana
{
    class Program
    {
        static void Main(string[] args)
        {
            int final = 0;
            int x = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();
            for (int i = 0; i < x; i++)
            {
                list = Console.ReadLine().Split(' ').ToList();
                if (list.Count == 4)
                {
                    citizens.Add(new Citizen(list[0], int.Parse(list[1]), int.Parse(list[2]), list[3]));
                }
                else if (list.Count == 3)
                {
                    rebels.Add(new Rebel(list[0], int.Parse(list[1]), list[2]));
                }
            }
            List<string> input =Console.ReadLine().Split(' ').ToList();
            while (input[0] != "End")
            {
                foreach (var item in citizens)
                {
                    if (item.Name == input[0])
                    {
                        item.BuyFood();
                    }
                }
                foreach (var item in rebels)
                {
                    if (item.Name == input[0])
                    {
                        item.BuyFood();
                    }
                }
                input = Console.ReadLine().Split(' ').ToList();
            }
            foreach (var item in citizens)
            {
                final += item.Food;
            }
            foreach(var item in rebels)
            {
                final += item.Food;
            }
            Console.WriteLine(final);

        }
    }
}