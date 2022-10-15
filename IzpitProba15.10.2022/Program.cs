using System;

namespace IzpitProba15._10._2022
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            Engine engine = new Engine(controller);

            engine.Run();
            Console.ReadKey();
        }
    }
}