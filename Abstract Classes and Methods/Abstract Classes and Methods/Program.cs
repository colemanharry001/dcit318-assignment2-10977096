using System;

namespace AbstractShapes
{
    // Define the abstract class Shape
    abstract class Shape
    {
        // Abstract method GetArea to be implemented by derived classes
        public abstract double GetArea();
    }

    // Define the derived class Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implement the GetArea method
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Define the derived class Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implement the GetArea method
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Shape myCircle = new Circle(5);
            Shape myRectangle = new Rectangle(4, 6);

            // Display their areas
            Console.WriteLine($"The area of the circle is: {myCircle.GetArea()}");
            Console.WriteLine($"The area of the rectangle is: {myRectangle.GetArea()}");
        }
    }
}
