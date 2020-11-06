using PjLinqSql.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;

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

            var r1 = from p in products where p.Category.Tier == 1 && p.Price < 900.00 select p;
            Print("Tier 1 and Price < 900", r1);

            var r2 = from p in products where p.Category.Name == "Tools" select p.Name;            
            Print("Names of Products from Category Tools", r2);

            var r3 = from p in products where p.Name[0] == 'C' select new { p.Name, p.Price, CategoryName = p.Category.Name };            
            Print("Names started with 'C' and Anonymous objects", r3);

            var r4 = from p in products where p.Category.Tier == 1 orderby p.Name orderby p.Price select p;            
            Print("Tier 1 order by price then by name", r4);

            var r5 = (from p in r4 select p).Skip(2).Take(4);
            Print("Tier 1 order by price then by name take 4", r5);

            var r6 = (from p in products select p).First();
            Console.WriteLine("First test1: " + r6);

            var r7 = (from p in products where p.Price > 7000 select p).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);

            var r8 = (from p in products where p.Id == 3 select p).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);

            var r9 = (from p in products where p.Id == 30 select p).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);

            var r10 = (from p in products select p).Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            var r11 = (from p in products select p).Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            var r16 = from p in products group p by p.Category;
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
