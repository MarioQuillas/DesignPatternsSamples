namespace ZoranVisitor.Visitors
{
    internal interface ICarVisitor : ICarPartVisitor
    {
        void VisitCar(string make, string model);
    }
}