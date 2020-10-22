using PjComparison.Entities;
using System;
using System.Collections.Generic;

namespace PjComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900));
            list.Add(new Product("Notebook", 3500));
            list.Add(new Product("Tablet", 750));

            //Expressão lambda, ordena os produtos por nome
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
