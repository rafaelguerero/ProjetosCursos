using System;

namespace PjVetorClasse {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Tamanho do vetor");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++) {

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine());

                vect[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0;
            for (int i = 0; i < n; i++) {
                soma += vect[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine("Preço médio = {0}", media.ToString("F2"));
        }
    }
}
