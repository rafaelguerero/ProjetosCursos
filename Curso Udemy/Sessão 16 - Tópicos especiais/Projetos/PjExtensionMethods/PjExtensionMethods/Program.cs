using System;
using PjExtensionMethods.Extensions;

namespace PjExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2019, 10, 14, 22, 35, 10);
            string s1 = "Good Morning";
            Console.WriteLine(dt.ElapsedTime());
            Console.WriteLine(s1.Cut(10));
        }
    }
}
