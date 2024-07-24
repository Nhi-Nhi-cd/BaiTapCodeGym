using System;

namespace Lession17
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape();
            Shape shape2 = new Shape("red", false);
            Console.WriteLine(shape1);
            Console.WriteLine(shape2);

            Circle circle1 = new Circle();
            Circle circle2 = new Circle(2.5);
            Circle circle3 = new Circle(3.5, "blue", true);
            Console.WriteLine(circle1);
            Console.WriteLine(circle2);
            Console.WriteLine(circle3);

            Rectangle rectangle1 = new Rectangle();
            Rectangle rectangle2 = new Rectangle(2.0, 4.0);
            Rectangle rectangle3 = new Rectangle(3.0, 6.0, "yellow", false);
            Console.WriteLine(rectangle1);
            Console.WriteLine(rectangle2);
            Console.WriteLine(rectangle3);

            Square square1 = new Square();
            Square square2 = new Square(5.0);
            Square square3 = new Square(4.0, "purple", true);
            Console.WriteLine(square1);
            Console.WriteLine(square2);
            Console.WriteLine(square3);
        }
    }
}
