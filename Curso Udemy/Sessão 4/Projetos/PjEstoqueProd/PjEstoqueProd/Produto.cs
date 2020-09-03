using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PjEstoqueProd {
    class Produto {
        public string nome;
        public double preco;
        public int qtd;

        public double ValorTotEstoque() {
            return preco * qtd;
        }

        public void AdicionarProduto(int qtde) {
            qtd += qtde;
        }

        public void RemoverProduto(int qtde) {
            qtd -= qtde;
        }

        //Sobreposição
        public override string ToString() {
            return "Nome: "+ nome + ", " +
                "Preço: R$" + preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +
                "Quantidade: " + qtd + ", " +
                "Valor total em estoque: " + ValorTotEstoque();
        }

    }
}
