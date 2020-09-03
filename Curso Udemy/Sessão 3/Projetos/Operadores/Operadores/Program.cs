using System;

namespace Operadores {
    class Program {
        static void Main(string[] args) {

            int a = 10;
            bool cond = a > 10;
            bool cond2 = a == 10;

            Console.WriteLine(cond);
            Console.WriteLine(cond2);

            /*Operadores comparativos && = E; || = OU; ! = Não*/
            bool c1 = 2 > 3 || 4 != 5;
            bool c2 = !(2 > 3) && 4 != 5;
            bool c3 = 10 < 5;
            bool c4 = c1 || c2 && c3;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
        }
    }
}
