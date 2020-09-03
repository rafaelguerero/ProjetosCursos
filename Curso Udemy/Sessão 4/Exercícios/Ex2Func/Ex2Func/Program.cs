using System;

namespace Ex2Func {
    class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();

            Console.WriteLine("Digite o Nome");
            f.nome = Console.ReadLine();

            Console.WriteLine("Digite o salário bruto.");
            f.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do imposto");
            f.imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do funcionário: " + f);

            f.Aumentarsalario(10.0);

            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}
