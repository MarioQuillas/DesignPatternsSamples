using System;
using System.Collections.Generic;
using ZoranVisitor.Visitors;

namespace ZoranVisitor
{
    class CarsView
    {
        private IEnumerable<Car> cars;

        public CarsView(IEnumerable<Car> cars)
        {
            this.cars = new List<Car>(cars);
        }

        public void Render()
        {
            foreach (Car car in this.cars)
            {
                string report = car.Accept(() => new CarToStringVisitor());
                Console.WriteLine(report);
            }
        }
    }
}
