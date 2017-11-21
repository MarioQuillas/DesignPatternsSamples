using System;
using System.Collections.Generic;
using ZoranVisitor.Visitors;

namespace ZoranVisitor
{
    internal class CarsView
    {
        private readonly IEnumerable<Car> cars;

        public CarsView(IEnumerable<Car> cars)
        {
            this.cars = new List<Car>(cars);
        }

        public void Render()
        {
            foreach (var car in cars)
            {
                var report = car.Accept(() => new CarToStringVisitor());
                Console.WriteLine(report);
            }
        }
    }
}