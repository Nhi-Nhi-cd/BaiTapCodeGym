using System;

namespace Lession17
{
    public class Square : Rectangle
    {
        public Square()
        {
            Width = 1.0;
            Length = 1.0;
        }

        public Square(double side)
        {
            Width = side;
            Length = side;
        }

        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
        }

        public double Side
        {
            get { return Width; }
            set
            {
                Width = value;
                Length = value;
            }
        }

        public override string ToString()
        {
            return $"A Square with side={Width}, which is a subclass of {base.ToString()}";
        }
    }
}
