using System;
using System.Net.NetworkInformation;

namespace OpAtribuicao {
    class Program {
        static void Main(string[] args) {

            /*Operadores: = += -= *= /= %= */

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            string x = "ABC";
            x += "C";
            Console.WriteLine(x);

            /* ++ e -- */
            int num = 10;
            int num2 = ++num;

            Console.WriteLine(num);
            Console.WriteLine(num2);
        }
    }
}
