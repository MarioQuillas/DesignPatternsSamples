namespace ZoranVisitor
{
    internal class CarRegistration
    {
        private readonly float capacity;
        private readonly string make;
        private readonly string model;
        private readonly int maxPassengers;

        public CarRegistration(string make, string model, float capacity,
            int maxPassengers)
        {
            this.make = make;
            this.model = model;
            this.capacity = capacity;
            this.maxPassengers = maxPassengers;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}cc {3} passengers",
                make, model, capacity,
                maxPassengers);
        }
    }
}