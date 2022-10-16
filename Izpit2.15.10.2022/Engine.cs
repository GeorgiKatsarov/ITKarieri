using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit2._15._10._2022
{
    public class Engine
    {
        private Controller controller;
        private bool isRunning;

        public Engine(Controller controller)
        {
            this.controller = controller;
            this.isRunning = true;
        }

        public void Run()
        {
            while (isRunning)
            {
                string[] splittedInput = Console.ReadLine().Split(':');

                string command = splittedInput[0];
                List<string> arguments = splittedInput
                    .ToList();

                string result = "";

                switch (command)
                {
                    case "CreateStore":

                        result = controller.CreateStore(arguments);
                        break;
                    case "ReceiveProduct":
                        result = controller.ReceiveProduct(arguments);
                        break;
                    case "SellProduct":
                        result = controller.SellProduct(arguments);
                        break;
                    case "StoreInfo":
                        result = controller.StoreInfo(arguments);
                        break;
                    case "Shutdown":
                        result = controller.Shutdown();
                        this.isRunning = false;
                        break;
                    default:
                        result = "Invalid command";
                        break;
                }

                Console.WriteLine(result);
            }
        }
    }
}
