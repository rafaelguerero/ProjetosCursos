using System;

namespace PjFuncao {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite três número:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());            

            int resultado = Maior( n1, n2, n3);
            Console.WriteLine("Maior: " + resultado);
        }

        static int Maior(int p1, int p2, int p3) {
            int maior;

            if (p1 > p2 && p1 > p3) {
                maior = p1;
            }
            else if (p2 > p3) {
                maior = p2;
            }
            else {
                maior = p3;
            }
            return maior;
        }
    }
}
