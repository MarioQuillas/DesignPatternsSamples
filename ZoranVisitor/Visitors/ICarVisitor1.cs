namespace ZoranVisitor.Visitors
{
    interface ICarVisitor<T>: ICarVisitor
    {
        T ProduceResult();
    }
}
