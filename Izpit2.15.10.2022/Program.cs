using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Izpit2._15._10._2022
{
    class Program
    {
        static void Main(string[] commands)
        {
            Controller controller = new Controller();
            Engine engine = new Engine(controller);

            engine.Run();
            Console.ReadKey();
        }
    }
    

}
