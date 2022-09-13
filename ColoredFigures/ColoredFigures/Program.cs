using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ColoredFigure item;
            for (int i = 0; i < n; i++)
            {
                string[] parameters = Console.ReadLine().Split(' ').ToArray();
                switch (parameters[0])
                {
                    case "Triangle":
                        item = new Triangle(parameters[1], int.Parse(parameters[2]));
                        break;
                    case "Circle":
                        item = new Circle(parameters[1], int.Parse(parameters[2]));
                        break;
                    default:
                        item = new Square(parameters[1], int.Parse(parameters[2]));
                        break;
                }
                Console.WriteLine(item.GetName() + ":");
                item.Show();
                Console.WriteLine("Area: {0:0.00}", Math.Round(item.GetArea(), 2));

            }

        }
    }
}
