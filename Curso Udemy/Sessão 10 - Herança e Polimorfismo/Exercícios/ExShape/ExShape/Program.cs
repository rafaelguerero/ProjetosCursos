using ExShape.Entities;
using ExShape.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExShape
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data");
                Console.Write("Rectangle or Circle? (r/c): ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black, Blue or Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (shape == 'r' || shape == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}
