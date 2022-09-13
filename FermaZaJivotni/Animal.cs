using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaZaJivotni
{
    internal abstract class  Animal
    {
        public string AnimalName { get; set; }
        public string AnimalType { get; set; }
        public double AnimalWeight { get; set; }
        public int FoodEaten { get; set; }

        public void MakeSound()
        {
            string sound = "";
            Console.WriteLine(sound);
        }
        public void EatFood(Food food)
        {
            FoodEaten += food.Quantity;
        }
    }
}
