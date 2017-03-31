using System.Drawing;

namespace VisitorDemoFunctional
{
    class TextElement : ScreenElement
    {
        public TextElement(TextContent text, RectangleF rect) {
            Text = text; Rect = rect;
        }

        public TextContent Text { get; private set; }
        public RectangleF Rect { get; private set; }

        public override void DrawPart(Graphics gr) {
            gr.DrawString(Text.Text, Text.Font, Brushes.Black, Rect);
        }
    }
}