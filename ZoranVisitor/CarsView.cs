using System;
using System.Collections.Generic;

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
                CarToStringVisitor converter = new CarToStringVisitor();
                car.Accept(converter);
                Console.WriteLine(converter.GetCarDescription());
            }
        }
    }
}
