using System;

namespace Lession17
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 1.0;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"A Circle with radius={Radius}, which is a subclass of {base.ToString()}";
        }
    }
}
