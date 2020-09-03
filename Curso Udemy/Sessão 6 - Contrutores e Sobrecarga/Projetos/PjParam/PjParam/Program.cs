using System;

namespace PjParam {
    class Program {
        static void Main(string[] args) {

            /*int s1 = Calculator.Sum(1, 7, 1);
            int s2 = Calculator.Sum(new int[] { 1, 7, 1, 10, 4 });

            Console.WriteLine(s1);
            Console.WriteLine(s2);*/

            int a = 10;
            int triple;

            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
