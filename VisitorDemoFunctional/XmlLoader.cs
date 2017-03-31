using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VisitorDemoFunctional
{
    static class XmlLoader
    {
        public static string Attribute(this XElement node, string name, string def)
        {
            var attr = node.Attribute(name);
            return attr != null ? attr.Value : def;
        }

        static Font ParseFont(XElement node)
        {
            var styleStr = node.Attribute("style", "");
            var style = styleStr.Contains("bold") ? FontStyle.Bold : FontStyle.Regular;
            style = styleStr.Contains("italic") ? (style | FontStyle.Italic) : style;
            return new Font(node.Attribute("font", "Calibri"), Single.Parse(node.Attribute("size", "12")), style);
        }

        static Orientation ParseOrientation(string orient)
        {
            return (orient == "horizontal") ? Orientation.Horizontal : Orientation.Vertical;
        }

        static DocumentPart LoadPart(XElement node)
        {
            switch (node.Name.LocalName)
            {
                case "titled":
                    return new TitledPart(new TextContent(node.Attribute("title", ""), ParseFont(node)),
                        LoadPart(node.Elements().First()));
                case "split":
                    var nodes = node.Elements().Select((el) => LoadPart(el)).ToFuncList();
                    return new SplitPart(ParseOrientation(node.Attribute("orientation", "")), nodes);
                case "text":
                    return new TextPart(new TextContent(node.Value, ParseFont(node)));
                case "image":
                    return new ImagePart(node.Attribute("filename", ""));
            }
            throw new Exception("Unknown element!");
        }

        public static DocumentPart LoadDocument(string url)
        {
            return LoadPart(XDocument.Load(url).Root);
        }
    }
}