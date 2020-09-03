using System;

namespace PjEncapsulamento {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 775.50, 6);

            p.Nome = "SmarTV";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Qtd);
        }
    }
}
