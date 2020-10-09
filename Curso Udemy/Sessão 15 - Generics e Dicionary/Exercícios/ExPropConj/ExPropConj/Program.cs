using System;
using System.Collections.Generic;

namespace ExPropConj
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>();
            SortedSet<int> b = new SortedSet<int>();
            SortedSet<int> c = new SortedSet<int>();
            int id;

            Console.Write("How many students for course A? ");
            int v = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < v; i++)
            {
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
                a.Add(id);
            }

            Console.Write("How many students for course B? ");
            v = int.Parse(Console.ReadLine());
            for (int i = 0; i < v; i++)
            {
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
                b.Add(id);
            }

            Console.Write("How many students for course C? ");
            v = int.Parse(Console.ReadLine());
            for (int i = 0; i < v; i++)
            {
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
                c.Add(id);
            }

            a.UnionWith(b);
            a.UnionWith(c);

            PrintCollection(a);
            Console.WriteLine("Total students: " + a.Count);

        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
