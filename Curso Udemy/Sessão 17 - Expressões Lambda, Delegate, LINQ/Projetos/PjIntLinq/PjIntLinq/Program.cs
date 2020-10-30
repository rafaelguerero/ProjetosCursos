using System;
using System.Linq;
using System.Collections.Generic;

namespace PjIntLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fonte de dados
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Consulta com expressão lambda filtrando número pares e os multiplicando por 10
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //Executar a consulta
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
