using System;
using System.Collections.Generic;
using ZoranVisitor.Visitors;

namespace ZoranVisitor
{
    internal class Seat
    {
        private readonly int capacity;

        private readonly string name;

        public Seat(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }

        public static IEnumerable<Seat> FourSeatConfiguration => new[]
        {
            new Seat("Driver", 1),
            new Seat("Passenger", 1),
            new Seat("Rear bench", 2)
        };

        public static IEnumerable<Seat> TwoSeatConfiguration => new[]
        {
            new Seat("Driver", 1),
            new Seat("Passenger", 1)
        };

        public void Accept(Func<ICarPartVisitor> visitorFactory)
        {
            visitorFactory().VisitSeat(name, capacity);
        }
    }
}