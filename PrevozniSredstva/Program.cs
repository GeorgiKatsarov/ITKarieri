using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevozniSredstva
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            Car car = new Car(double.Parse(list[1]), double.Parse(list[2]));
            List<string> list1 = Console.ReadLine().Split(' ').ToList();
            Truck truck = new Truck(double.Parse(list1[1]), double.Parse(list1[2]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> list2 = (Console.ReadLine().Split(' ').ToList());
                if (list2[1] == "Car")
                {
                    if (list2[0] == "Drive")
                    {
                        car.LitersFuel -=  (double.Parse(list2[2])* (car.FuelEficency+0.9));
                        if (car.DriveCar(double.Parse(list2[2])))
                        {
                            Console.WriteLine($"Car travelled {list2[2]} km");
                           
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                            car.LitersFuel += (double.Parse(list2[2]) * (car.FuelEficency + 0.9));
                        }
                    }
                    else if (list2[0] == "Refuel" )
                    {
                        car.Refuel(double.Parse(list2[2]));
                    }
                    
                }
                else if (list2[1] =="Truck")
                {
                    if (list2[0] == "Drive")
                    {
                        truck.LitersFuel -= (double.Parse(list2[2]) * (truck.FuelEficency+1.6));
                        if (truck.DriveCar(double.Parse(list2[2])))
                        {   
                            Console.WriteLine($"Truck travelled {list2[2]} km");

                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                            truck.LitersFuel += (double.Parse(list2[2]) * (truck.FuelEficency + 1.6));
                        }
                    }
                    else if (list2[0] == "Refuel" )
                    {
                        truck.Refuel(double.Parse(list2[2]) );
                    }
                    
                }
            }
            Console.WriteLine($"Car: {car.LitersFuel:f2}");
            Console.WriteLine($"Truck: {truck.LitersFuel:f2}");

        }
    }
}

