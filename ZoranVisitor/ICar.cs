using System;
using ZoranVisitor.Visitors;

namespace ZoranVisitor
{
    internal interface ICar
    {
        CarRegistration Register();
        void Accept(Func<ICarVisitor> visitorFactory);
        T Accept<T>(Func<ICarVisitor<T>> visitorFactory);
    }
}