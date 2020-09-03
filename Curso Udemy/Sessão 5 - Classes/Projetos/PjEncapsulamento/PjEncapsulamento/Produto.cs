using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PjEncapsulamento {
    public class Produto {
        //Nome tem uma lógica customizada
        private string _nome;
        //AutoProprierty - pro tab + tab
        public double Preco { get; private set; }
        public int Qtd { get; private set; }

        public Produto() {
        }

        public Produto(string nome, double preco, int qtd) {
            _nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        //Implementação de uma proprierty
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) { _nome = value; }                    
            }
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
            return "Nome: " + _nome + ", " +
                "Preço: R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +
                "Quantidade: " + Qtd + ", " +
                "Valor total em estoque: " + ValorTotEstoque();
        }

    }
}
