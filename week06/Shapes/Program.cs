using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("red", 10);
        shapes.Add(square1);

        Rectangle rect1 = new Rectangle("white", 5, 4);
        shapes.Add(rect1);

        Circle circle1 = new Circle("blue", 9);
        shapes.Add(circle1);


        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
        }
    }
}