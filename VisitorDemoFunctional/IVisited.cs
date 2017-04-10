namespace VisitorDemoFunctional
{
    internal interface IVisited
    {
        T Accept<T>(DocumentPartVisitor<T> visitor, T state);
    }
}