using System;

namespace PjGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teste comentário git
            PrintService<int> ps = new PrintService<int>();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                ps.AddValue(x);
            }
            ps.Print();
        }
    }
}
