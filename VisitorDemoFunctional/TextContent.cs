using System.Drawing;

namespace VisitorDemoFunctional
{
    internal class TextContent
    {
        public TextContent(string text, Font font)
        {
            Text = text;
            Font = font;
        }

        public string Text { get; }
        public Font Font { get; }
    }
}