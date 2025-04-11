using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // A list that can hold any objects derived from Shape
        List<Shape> shapes = new List<Shape>();

        // Create instances of each shape and add them to the list
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        // Iterate through the list and display color and area
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }
    }
}
