using System;
using System.Globalization;

namespace PjEstoqueProd {
    class Program {
        static void Main(string[] args) {


            Console.WriteLine("Dados do produto");
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Preço:");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade:");
            int qtd = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);
            Produto p2 = new Produto(nome, preco, qtd);
            Produto p3 = new Produto("Carro", 25000, 1);
            Produto p4 = new Produto {Nome = "Moto", Preco = 10000, Qtd = 3 };

            Console.WriteLine(p);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
        }
    }
}
