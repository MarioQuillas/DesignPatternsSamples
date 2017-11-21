using System.Drawing;

namespace VisitorDemoFunctional
{
    internal abstract class ScreenElement
    {
        public abstract void DrawPart(Graphics gr);
    }
}