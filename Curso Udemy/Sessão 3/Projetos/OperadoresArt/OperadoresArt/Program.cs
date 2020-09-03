using System;

namespace OperadoresArt {
    class Program {
        static void Main(string[] args) {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10 / 8D;

            //Variáveis baskara
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("Valor delta:" + delta);
            Console.WriteLine("X1: " + x1);
            Console.WriteLine("X2: " + x2);
        }
    }
}
