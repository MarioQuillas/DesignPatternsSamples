using System;
using System.Linq;
using System.Windows.Forms;

namespace VisitorDemoFunctional
{
    internal class SplitPart : DocumentPart
    {
        public SplitPart(Orientation orientation, FuncList<DocumentPart> parts)
        {
            Orientation = orientation;
            Parts = parts;
        }

        public Orientation Orientation { get; }
        public FuncList<DocumentPart> Parts { get; }

        public override T Accept<T>(DocumentPartVisitor<T> visitor, T state)
        {
            return visitor.VisitSplitPart(this, state);
        }

        public override T Aggregate<T>(Func<T, DocumentPart, T> f, T state)
        {
            var nstate = f(state, this);
            return Parts.Aggregate(nstate, (st, part) => part.Aggregate(f, st));
        }
    }
}