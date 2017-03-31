using System;
using System.Linq;
using System.Windows.Forms;

namespace VisitorDemoFunctional
{
    class SplitPart : DocumentPart
    {
        public SplitPart(Orientation orientation, FuncList<DocumentPart> parts) {
            Orientation = orientation; Parts = parts;
        }
        public override T Accept<T>(DocumentPartVisitor<T> visitor, T state) {
            return visitor.VisitSplitPart(this, state);
        }
        public override T Aggregate<T>(Func<T, DocumentPart, T> f, T state) {
            T nstate = f(state, this);
            return Parts.Aggregate(nstate, (st, part) => part.Aggregate(f, st));
        }
        public Orientation Orientation { get; private set; }
        public FuncList<DocumentPart> Parts { get; private set; }
    }
}