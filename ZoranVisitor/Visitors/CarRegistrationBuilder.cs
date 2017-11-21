namespace ZoranVisitor.Visitors
{
    internal class CarRegistrationBuilder : ICarVisitor<CarRegistration>
    {
        private readonly ICar car;
        private float engineCapacity;
        private string make;
        private string model;
        private int seatsCount;

        public CarRegistrationBuilder(ICar car)
        {
            this.car = car;
        }

        public void VisitCar(string make, string model)
        {
            this.make = make;
            this.model = model;
        }

        public void VisitEngine(EngineStructure structure, EngineStatus status)
        {
            engineCapacity = structure.CylinderVolume;
        }

        public void VisitSeat(string name, int capacity)
        {
            seatsCount += capacity;
        }

        public CarRegistration ProduceResult()
        {
            car.Accept(() => (ICarVisitor) this);
            return new CarRegistration(make.ToUpper(), model,
                engineCapacity,
                seatsCount);
        }
    }
}