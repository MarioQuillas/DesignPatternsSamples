using System.Drawing;

namespace VisitorDemoFunctional
{
    internal class TranslationState
    {
        public RectangleF Rect { get; set; }
        public FuncList<ScreenElement> Result { get; set; }
    }
}