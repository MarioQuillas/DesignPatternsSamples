using System.Drawing;

namespace VisitorDemoFunctional
{
    class TextContent
    {
        public TextContent(string text, Font font) {
            Text = text; Font = font;
        }

        public string Text { get; private set; }
        public Font Font { get; private set; }
    }
}