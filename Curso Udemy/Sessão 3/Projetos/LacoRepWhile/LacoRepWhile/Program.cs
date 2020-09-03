using System;
using System.Globalization;

namespace LacoRepWhile {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (n1 >= 0) {
                double raiz = Math.Sqrt(n1);
                Console.WriteLine("A raíz do número é: " + raiz.ToString("F3"), CultureInfo.InvariantCulture);
                Console.Write("Digite outro número: ");
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo!");

        }
    }
}
