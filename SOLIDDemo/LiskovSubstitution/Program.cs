using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        IShape rectangle = new Rectangle(5, 10);
        IShape square = new Square(5);

        // Both shapes now work correctly
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}"); // Output: 50
        Console.WriteLine($"Square area: {square.GetArea()}");      // Output: 25

        // We can use them polymorphically
        List<IShape> shapes = new List<IShape>
        {
            new Rectangle(4, 6),
            new Square(5)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape area: {shape.GetArea()}");
        }
    }
} 