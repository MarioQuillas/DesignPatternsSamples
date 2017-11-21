namespace ZoranVisitor.Visitors
{
    internal interface ICarVisitor<T> : ICarVisitor
    {
        T ProduceResult();
    }
}