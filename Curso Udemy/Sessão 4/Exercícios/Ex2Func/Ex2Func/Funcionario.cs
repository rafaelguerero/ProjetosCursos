using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex2Func {
     class Funcionario {
        public string nome;
        public double salario, imposto;

        public double SalarioLiquido() {
            return salario - imposto;
        }

        public void Aumentarsalario(double porc) {
            salario *= (1 + porc/100);
        }

        public override string ToString() {
            string separador = ", ";
            return "Nome: " + nome + separador + "Salário: " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture) + separador + "Imposto: " + imposto;
        }
    }
}
