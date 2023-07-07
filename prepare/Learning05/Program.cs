using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine(Math.Pow(5,2));

        Square square = new Square();
        square.SetColor("yellow");
        square.SetSide(3);

        Rectangle rectangle = new Rectangle(3, 4, "blue");

        Circle circle = new Circle(1, "red");

        // Console.WriteLine(square.GetArea());
        // Console.WriteLine(rectangle.GetArea());
        // Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
         {
            Console.WriteLine($"{shape.GetName()} {shape.GetColor()} {shape.GetArea()}");
        }


    }
}