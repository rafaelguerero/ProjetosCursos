using System;

namespace ExercicioClasse {
    class Program {
        static void Main(string[] args) {

            /*Pessoa p1 = new Pessoa(), p2 = new Pessoa();

            Console.WriteLine("Dados da Primeira pessoa:");
            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da Segunda pessoa:");
            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: {0}, Idade: {1}", p1.nome, p1.idade);
            Console.WriteLine("Nome: {0}, Idade: {1}", p2.nome, p2.idade);
            if (p1.idade > p2.idade) {
                Console.WriteLine("Pessoa mais velha: {0}", p1.nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha: {0}", p2.nome);
            }
            */

            Funcionario f1 = new Funcionario(), f2 = new Funcionario();

            Console.WriteLine("Funcionário 1:");
            f1.nome = Console.ReadLine();
            f1.salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Funcionário 2:");
            f2.nome = Console.ReadLine();
            f2.salario = double.Parse(Console.ReadLine());

            double media = (f1.salario + f2.salario) / 2;
            Console.WriteLine("Nome: {0}, Salário: {1}", f1.nome, f1.salario.ToString("F2"));
            Console.WriteLine("Nome: {0}, Salário: {1}", f2.nome, f2.salario.ToString("F2"));
            Console.WriteLine("Média: " + media.ToString("F2"));

        }
    }
}
