using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {   public delegate void ReturnMessege(string msg);
        static void Main(string[] args)
        {

            ReturnMessege returner = (string messegge) => Console.WriteLine("Dispatcher name changed to " + messegge); ;
            string input = Console.ReadLine();
            while (input != "End")
            {
                returner(input);
                input = Console.ReadLine(); 
            }
        }
    }
}