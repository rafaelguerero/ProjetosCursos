using System;
using System.Diagnostics.Tracing;
using System.Globalization;

namespace DesafioArvore {
    class Program {
        static void Main(string[] args) {

            int linhas;
            Console.WriteLine("Digite a quantidade de linhas");
            linhas = int.Parse(Console.ReadLine());
            for (int i = 0; i <= linhas * 2; i++)
                if (i % 2 != 0)
                    Console.WriteLine(new string(' ', (linhas * 2 - i) / 2) + new string('*', i));


        }
    }
}
