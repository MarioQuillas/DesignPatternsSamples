// --------------------------------------------------------------------------
// Functional Programming in .NET - Chapter 7
// --------------------------------------------------------------------------
// This file contains code samples that are not related to the primary
// example of the chapter (document drawing application).
// --------------------------------------------------------------------------

namespace VisitorDemoFunctional
{
    // --------------------------------------------------------------------------
    // Section 7.1.2 Functional data structures in C#

    // Listing 7.3 Immutable 'Rect' type (C#)
    internal class Rect
    {
        // Readonly properties of the type

        // Construct the value
        public Rect(float left, float top, float width, float height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }

        public float Left { get; }

        public float Top { get; }

        public float Width { get; }

        public float Height { get; }

        // Returns 'Rect' with modified 'Left' property
        public Rect WithLeft(float left)
        {
            // Create a copy of the object
            return new Rect(left, Top, Width, Height);
        }

        // Other 'With' methods are similar...
        public Rect WithTop(float top)
        {
            return new Rect(Left, top, Width, Height);
        }

        public Rect WithWidth(float width)
        {
            return new Rect(Left, Top, width, Height);
        }

        public Rect WithHeight(float height)
        {
            return new Rect(Left, Top, Width, height);
        }
    }

    // Working with immutable types

    internal class Demo
    {
        private static void IntroMain()
        {
            var rc = new Rect(0.0f, 0.0f, 100.0f, 100.0f);
            var moved = rc.WithLeft(10.0f).WithTop(10.0f);
        }
    }
}