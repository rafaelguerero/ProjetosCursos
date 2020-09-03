using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PjEstoqueProd {
    class Produto {
        public string Nome;
        public double Preco;
        public int Qtd;

        public Produto() {
            Qtd = 10;
        }

        //Sobrecarga - Dois parâmetros - Reaproveita o valor da propriedade Qtd
        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }

        //Construtor com todos os parâmetros
        public Produto(string nome, double preco, int qtd) : this(nome, preco) {
            Qtd = qtd;
        }

        public double ValorTotEstoque() {
            return Preco * Qtd;
        }

        public void AdicionarProduto(int qtde) {
            Qtd += qtde;
        }

        public void RemoverProduto(int qtde) {
            Qtd -= qtde;
        }

        //Sobreposição
        public override string ToString() {
            return "Nome: " + Nome + ", " +
                "Preço: R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +
                "Quantidade: " + Qtd + ", " +
                "Valor total em estoque: " + ValorTotEstoque();
        }

    }
}
