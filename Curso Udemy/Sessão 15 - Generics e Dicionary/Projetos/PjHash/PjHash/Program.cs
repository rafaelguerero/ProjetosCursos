using PjHash.Entities;
using System;
using System.Collections.Generic;

namespace PjHash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>
            {
                new Product("TV", 900.50),
                new Product("Notebook", 2500.00)
            };

            HashSet<Point> b = new HashSet<Point>
            {
                new Point(3, 4),
                new Point(5, 10)
            };

            Product prod = new Product("Notebook", 2500.00);

            Console.WriteLine(a.Contains(prod));

            //Struct compara por conteúdo e não por referência
            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));

        }
    }
}
