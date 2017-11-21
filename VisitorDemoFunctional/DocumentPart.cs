using System;

namespace VisitorDemoFunctional
{
    internal abstract class DocumentPart : IVisited
    {
        public abstract T Accept<T>(DocumentPartVisitor<T> visitor, T state);
        public abstract T Aggregate<T>(Func<T, DocumentPart, T> f, T state);
    }
}