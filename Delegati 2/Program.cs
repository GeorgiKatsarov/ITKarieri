using System;
using System.Collections;
using System.Linq;

namespace Delegati
{
    class Program
    {
        public delegate List<int> returnEven(List<int> list);
        public delegate List<int> returnOdd(List<int> list);
        static void Main(string[] args)
        {
            returnEven even = (List<int> list) => list.Where(x => x % 2 == 0).ToList() ; ;
            returnOdd odd = (List<int> list) => list.Where(x => x % 2 != 0).ToList(); ;

            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine("Even");
            Console.WriteLine("...........................................");
            Console.WriteLine(String.Join(" ", even(list)));
            Console.WriteLine("Odd");
            Console.WriteLine("...........................................");
            Console.WriteLine(String.Join(" ",odd(list)));
        }
    }
}