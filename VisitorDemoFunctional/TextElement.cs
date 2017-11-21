using System.Drawing;

namespace VisitorDemoFunctional
{
    internal class TextElement : ScreenElement
    {
        public TextElement(TextContent text, RectangleF rect)
        {
            Text = text;
            Rect = rect;
        }

        public TextContent Text { get; }
        public RectangleF Rect { get; }

        public override void DrawPart(Graphics gr)
        {
            gr.DrawString(Text.Text, Text.Font, Brushes.Black, Rect);
        }
    }
}