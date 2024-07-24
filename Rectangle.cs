using System;

namespace Lession17
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle()
        {
            Width = 1.0;
            Length = 1.0;
        }

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            Width = width;
            Length = length;
        }

        public double GetArea()
        {
            return Width * Length;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Length);
        }

        public override string ToString()
        {
            return $"A Rectangle with width={Width} and length={Length}, which is a subclass of {base.ToString()}";
        }
    }
}
