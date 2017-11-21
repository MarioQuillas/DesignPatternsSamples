using System;

namespace VisitorDemoFunctional
{
    internal class TitledPart : DocumentPart
    {
        public TitledPart(TextContent text, DocumentPart body)
        {
            Text = text;
            Body = body;
        }

        public TextContent Text { get; }
        public DocumentPart Body { get; }

        public override T Accept<T>(DocumentPartVisitor<T> visitor, T state)
        {
            return visitor.VisitTitledPart(this, state);
        }

        public override T Aggregate<T>(Func<T, DocumentPart, T> f, T state)
        {
            return Body.Aggregate(f, f(state, this));
        }
    }
}