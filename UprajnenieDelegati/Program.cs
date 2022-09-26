using System;
using System.Collections;
using System.Linq;

namespace Delegati
{
    class Program
    {
        public delegate int returnSum(int a, int b);
        public delegate int returnDif(int a, int b);
        public delegate List<double> solveQuadratic();
        
        static void Main(string[] args)
        {
            int i = 1;
            returnSum returnSum = (int a, int b) => a + b;
            returnDif returnDif = (int a, int b)=> a - b;

            Console.WriteLine(returnSum(1, 7));
            Console.WriteLine(returnDif(1, 7));
            findQuadratic();
             void findQuadratic()
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                List<double> result = new List<double>();
                result.Add((-1 * b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
                result.Add((-1 * b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
                foreach (var item in result)
                {
                    
                    if (double.IsNaN(item))
                    {
                        Console.WriteLine("Something went wrong");
                    }
                    else Console.WriteLine($"X{i} is "+ item);
                    i++;
                }
                
            }
        }
       
    }
}