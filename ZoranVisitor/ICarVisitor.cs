namespace ZoranVisitor
{
    interface ICarVisitor: ICarPartVisitor
    {
        void VisitCar(string make, string model);
    }
}
