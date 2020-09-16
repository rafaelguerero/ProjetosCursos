using System;
using System.Collections.Generic;

namespace PjHashSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }

            SortedSet<int> a = new SortedSet<int> { 0, 2, 4, 5, 7, 10 };
            SortedSet<int> b = new SortedSet<int> { 1, 3, 6, 8, 9, 10 , 11 };
            SortedSet<int> c = new SortedSet<int> (a);

            //Une o conjunto c com o b
            c.UnionWith(b);
            PrintCollection(c);

            //intersecção
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //Diferença
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

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
