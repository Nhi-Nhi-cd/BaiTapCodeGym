using System;

namespace Lession17
{
    public class Shape
    {
        public string Color { get; set; }
        public bool Filled { get; set; }

        public Shape()
        {
            Color = "green";
            Filled = true;
        }

        public Shape(string color, bool filled)
        {
            Color = color;
            Filled = filled;
        }

        public override string ToString()
        {
            return $"A Shape with color of {Color} and {(Filled ? "filled" : "not filled")}";
        }
    }
}
