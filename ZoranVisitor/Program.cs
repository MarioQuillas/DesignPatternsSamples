using System;

namespace ZoranVisitor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cars = new CarRepository().GetAll();

            foreach (var car in cars)
                Console.WriteLine(car.Register());

            Console.Write("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}