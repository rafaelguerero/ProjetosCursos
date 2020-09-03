using System;
using System.Globalization;

namespace Ex3NotaAluno {
    class Program {
        static void Main(string[] args) {

            Aluno a = new Aluno();

            Console.WriteLine("Digite o nome do aluno:");
            a.nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota:");
            a.n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            a.n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            a.n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final: " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(a.Situacao());
        }
    }
}
