using System;

namespace VisitorDemoFunctional
{
    class ImagePart : DocumentPart
    {
        public ImagePart(string url) {
            Url = url;
        }
        public override T Accept<T>(DocumentPartVisitor<T> visitor, T state) {
            return visitor.VisitImagePart(this, state);
        }
        public override T Aggregate<T>(Func<T, DocumentPart, T> f, T state) {
            return f(state, this);
        }
        public string Url { get; private set; }
    }
}