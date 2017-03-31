using System;

namespace VisitorDemoFunctional
{
    class TitledPart : DocumentPart
    {
        public TitledPart(TextContent text, DocumentPart body) {
            Text = text; Body = body;
        }
        public override T Accept<T>(DocumentPartVisitor<T> visitor, T state) {
            return visitor.VisitTitledPart(this, state);
        }
        public override T Aggregate<T>(Func<T, DocumentPart, T> f, T state) {
            return Body.Aggregate(f, f(state, this));
        }
        public TextContent Text { get; private set; }
        public DocumentPart Body { get; private set; }
    }
}