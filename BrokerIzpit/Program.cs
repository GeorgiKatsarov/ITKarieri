using System;

namespace BrokerIzpit
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CompanyController controller = new CompanyController();
            Engine engine = new Engine(controller);

            engine.Run();
            Console.ReadKey();
        }
    }
}