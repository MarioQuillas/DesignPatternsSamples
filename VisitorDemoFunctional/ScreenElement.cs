using System.Drawing;

namespace VisitorDemoFunctional
{
    abstract class ScreenElement
    {
        public abstract void DrawPart(Graphics gr);
    }
}