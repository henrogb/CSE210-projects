using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<Shape> shapes = new List<Shape>();

        
        shapes.Add(new Square("Red", 4));       
        shapes.Add(new Rectangle("Blue", 5, 6)); 
        shapes.Add(new Circle("Green", 3));      

        
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea()}");
        }
    }
}
