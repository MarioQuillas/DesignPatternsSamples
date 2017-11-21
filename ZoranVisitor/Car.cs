using System;
using System.Collections.Generic;
using ZoranVisitor.Visitors;

namespace ZoranVisitor
{
    internal class Car : ICar
    {
        private readonly Engine engine;

        private readonly string make;
        private readonly string model;
        private readonly IEnumerable<Seat> seats;

        public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
        {
            this.make = make;
            this.model = model;
            this.engine = engine;
            this.seats = new List<Seat>(seats);
        }

        public CarRegistration Register()
        {
            return new CarRegistrationBuilder(this).ProduceResult();
        }

        public void Accept(Func<ICarVisitor> visitorFactory)
        {
            var visitor = visitorFactory();
            engine.Accept(() => visitor);
            foreach (var seat in seats)
                seat.Accept(() => visitor);
            visitor.VisitCar(make, model);
        }

        public T Accept<T>(Func<ICarVisitor<T>> visitorFactory)
        {
            var visitor = visitorFactory();
            Accept(() => (ICarVisitor) visitor);
            return visitor.ProduceResult();
        }
    }
}