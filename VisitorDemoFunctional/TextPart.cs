using System;

namespace VisitorDemoFunctional
{
    internal class TextPart : DocumentPart
    {
        public TextPart(TextContent text)
        {
            Text = text;
        }

        public TextContent Text { get; }

        public override T Accept<T>(DocumentPartVisitor<T> visitor, T state)
        {
            return visitor.VisitTextPart(this, state);
        }

        public override T Aggregate<T>(Func<T, DocumentPart, T> f, T state)
        {
            return f(state, this);
        }
    }
}