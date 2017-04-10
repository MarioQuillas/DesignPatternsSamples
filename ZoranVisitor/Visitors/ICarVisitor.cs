namespace ZoranVisitor.Visitors
{
    interface ICarVisitor: ICarPartVisitor
    {
        void VisitCar(string make, string model);
    }
}
