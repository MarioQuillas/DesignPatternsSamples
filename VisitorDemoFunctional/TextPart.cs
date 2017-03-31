using System;

namespace VisitorDemoFunctional
{
    class TextPart : DocumentPart
    {
        public TextPart(TextContent text) {
            Text = text;
        }
        public override T Accept<T>(DocumentPartVisitor<T> visitor, T state) {
            return visitor.VisitTextPart(this, state);
        }
        public override T Aggregate<T>(Func<T, DocumentPart, T> f, T state) {
            return f(state, this);
        }
        public TextContent Text { get; private set; }
    }
}