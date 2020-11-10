using PJLinqRef.Entities;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PJLinqRef
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computer", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 3000.00, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.00, Category = c1 },
                new Product() { Id = 3, Name = "Saw", Price = 75.50, Category = c1 },
                new Product() { Id = 4, Name = "Tv", Price = 1800.00, Category = c3 },
                new Product() { Id = 5, Name = "Tablet", Price = 1300.80, Category = c2 },
                new Product() { Id = 6, Name = "Camera", Price = 700, Category = c3 },
                new Product() { Id = 7, Name = "Level", Price = 70.00, Category = c1 },
                new Product() { Id = 9, Name = "MacBook", Price = 6500.00, Category = c2 },
                new Product() { Id = 9, Name = "Sound Bar", Price = 800.00, Category = c3 },
                new Product() { Id = 10, Name = "Printer", Price = 700.00, Category = c3 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            Print("Tier 1 and Price < 900", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Names of Products from Category Tools", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Names started with 'C' and Anonymous objects", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 order by price then by name", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Tier 1 order by price then by name take 4", r5);

            var r6 = products.First();
            Console.WriteLine("First test1: " + r6);

            var r7 = products.Where(p => p.Price > 7000).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Sum of category 1: " + r12);

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Average of category 1: " + r13);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average of category 5: " + r14);

            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);

            var r16 = products.GroupBy(p => p.Category);
            Console.WriteLine();
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ": ");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}
