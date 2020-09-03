using System;
using System.Dynamic;

namespace ExeEntradaDados {
    class Program {
        static void Main(string[] args) {

            string nome, sobrenome;
            int qtdQuartos, idade;
            double preco, altura;
            string[] vet;

            Console.WriteLine("Digite seu nome completo:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de quartos da sua casa:");
            qtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de um produto:");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu sobrenome, idade e altura(Mesma Linha)");
            vet = Console.ReadLine().Split(' ');
            sobrenome = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2]);

            Console.WriteLine("Saídas:\n" + "Nome: {0}\n" + "Quartos: {1}\n" + "Preço Produto: {2}\n" + "Sobrenome: {3}\n" + "Idade: {4}\n" + "Altura: {5}",
                nome, qtdQuartos, preco.ToString("F2"), sobrenome, idade, altura.ToString("F2")); 


        }
    }
}
