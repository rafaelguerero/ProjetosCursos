using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExBanco {
    class Conta {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depositoIni) : this(numero, titular) {
            Deposito(depositoIni);
        }

        public void Deposito(double valor) {
            if (valor > 0) {
                Saldo += valor;
            }
        }

        public void Saque(double valor) {
            double taxa = 5.0;
            if (valor > 0) {
                Saldo -= valor + taxa;
            }
        }

        public override string ToString() {
            return "Número: " + Numero + "; " +
                   " Titular: " + Titular + "; " +
                   " Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
