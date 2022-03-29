using System;

namespace FactoryPattern
{
    interface Shape
    {
        void draw();
    }
    class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }

    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }

    class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ShapeFactory shape = new ShapeFactory();
            Shape shape1 = shape.getShape("CIRCLE");
            shape1.draw();
            Shape shape2 = shape.getShape("RECTANGLE");
            shape2.draw();
        }
    }
}
