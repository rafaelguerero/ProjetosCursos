using ExProduct.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data");
                Console.Write("Common, Used or Imported (c/u/i): ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (type == 'i' || type == 'I')
                {
                    Console.Write("Custom Fee: ");
                    double cFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    ImportedProduct p = new ImportedProduct(name, price, cFee);
                    list.Add(p);
                }
                else if (type == 'u' || type == 'U')
                {
                    Console.Write("Manufacture date: ");
                    DateTime manuDate = DateTime.Parse(Console.ReadLine());
                    UsedProduct p = new UsedProduct(name, price, manuDate);
                    list.Add(p);
                }
                else
                {
                    Product p = new Product(name, price);
                    list.Add(p);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Price TAGs:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
