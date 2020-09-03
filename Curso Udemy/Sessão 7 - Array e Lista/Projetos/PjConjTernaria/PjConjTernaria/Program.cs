using System;

namespace PjConjTernaria {
    class Program {
        static void Main(string[] args) {

            double preco = double.Parse(Console.ReadLine());
            double desconto = preco < 20? preco * 0.1 : preco * 0.5;

            Console.WriteLine(desconto);
        }
    }
}
