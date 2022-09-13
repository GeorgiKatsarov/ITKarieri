
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaZaJivotni
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<string> list1 = Console.ReadLine().Split(' ').ToList();
            string end = Console.ReadLine();
            Vegetable vegetable = new Vegetable(int.Parse(list1[1]));
            Meat meat = new Meat(int.Parse(list1[1]));
            

            if (list[0] == "Cat")
            {    
                Console.WriteLine("Meowwww");
                Cat cat = new Cat(list[1], double.Parse(list[2]), list[3], list[4]);
                cat.EatFood(meat);
                
                Console.WriteLine($"Cat[{cat.AnimalName}, {cat.Breed}, {cat.AnimalWeight}, {cat.LivingRegion}, {cat.FoodEaten}]");
            }
            else if (list[0] == "Tiger")
            {
                Console.WriteLine("ROAAR!!!");
                Tiger tiger = new Tiger(list[1], double.Parse(list[2]), list[3]);
                if (list1[0]=="Meat")
                {
                    tiger.EatFood(meat);
                }
                else 
                {
                    Console.WriteLine("Tigers are not eating that type of food!");
                }
                
                Console.WriteLine($"Tiger[{tiger.AnimalName}, {tiger.AnimalWeight}, {tiger.LivingRegion}, {tiger.FoodEaten}]");
            }
            else if (list[0] == "Zebra")
            {  
                Console.WriteLine("Zs");
                Zebra zebra = new Zebra(list[1], double.Parse(list[2]), list[3]);
                if (list1[0] == "Vegetable")
                {
                    zebra.EatFood(vegetable);
                }
                else
                {
                    Console.WriteLine("Zebras are not eating that type of food!");
                }
               
                Console.WriteLine($"Zebra[{zebra.AnimalName}, {zebra.AnimalWeight}, {zebra.LivingRegion}, {zebra.FoodEaten}]");
            }
            else if (list[0] == "Mouse")
            { 
                Console.WriteLine("SQEEEAAK");
                Mouse mouse = new Mouse(list[1], double.Parse(list[2]), list[3]);
                if (list1[0] == "Vegetable")
                {
                    mouse.EatFood(vegetable);
                }
                else
                {
                    Console.WriteLine("Mice are not eating that type of food!");
                }
               
                Console.WriteLine($"Mouse[{mouse.AnimalName}, {mouse.AnimalWeight}, {mouse.LivingRegion}, {mouse.FoodEaten}]");
            }

        }
    }
}