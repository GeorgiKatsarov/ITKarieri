using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerIzpit
{
    public class Engine
    {
        private CompanyController controller;
        private bool isRunning;

        public Engine(CompanyController controller)
        {
            this.controller = controller;
            this.isRunning = true;
        }

        public void Run()
        {
            while (isRunning)
            {
                string[] splittedInput = Console.ReadLine().Split('*');

                string command = splittedInput[0];
                List<string> arguments = splittedInput
                    .ToList();

                string result = "";

                switch (command)
                {
                    case "CreateCompany":
                        result = controller.CreateCompany(arguments);
                        break;
                    case "RegisterBuilding":
                        result = controller.RegisterBuilding(arguments);
                        break;
                    case "RegisterBroker":
                        result = controller.RegisterBroker(arguments);
                        break;
                    case "RentBuilding":
                        result = controller.RentBuilding(arguments);
                        break;
                    case "CompanyInfo":
                        result = controller.CompanyInfo(arguments);
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
