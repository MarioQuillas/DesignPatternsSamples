using System.Drawing;

namespace VisitorDemoFunctional
{
    internal class ImageElement : ScreenElement
    {
        public ImageElement(string path, RectangleF rect)
        {
            Path = path;
            Rect = rect;
        }

        public string Path { get; }
        public RectangleF Rect { get; }

        public override void DrawPart(Graphics gr)
        {
            var bmp = new Bitmap(Path);
            float wspace = Rect.Width / 10.0f, hspace = Rect.Height / 10.0f;
            var rc = new RectangleF(Rect.Left + wspace, Rect.Top + hspace, Rect.Width - 2 * wspace,
                Rect.Height - 2 * hspace);
            gr.DrawImage(bmp, rc);
        }
    }
}