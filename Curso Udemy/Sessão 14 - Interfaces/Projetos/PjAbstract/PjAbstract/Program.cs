using PjAbstract.Model.Entities;
using PjAbstract.Model.Enums;
using System;

namespace PjAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle()
            {
                Radius = 2.0,
                Color = Color.white
            };

            IShape s2 = new Rectangle()
            {
                Width = 3.5,
                Height = 4.2,
                Color = Color.black
            };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
