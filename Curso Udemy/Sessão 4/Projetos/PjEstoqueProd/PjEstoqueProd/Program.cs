using System;
using System.Globalization;

namespace PjEstoqueProd {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();

            Console.WriteLine("Digite os dados do produto(Nome, Preço, Quantidade): ");
            p.nome = Console.ReadLine();
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite o número de produtos a ser adicionado:");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtde);

            Console.WriteLine("Digite o número de produtos a ser removido:");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtde);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
        }
    }
}
