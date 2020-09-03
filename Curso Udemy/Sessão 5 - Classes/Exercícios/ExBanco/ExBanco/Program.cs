using System;

namespace ExBanco {
    class Program {
        static void Main(string[] args) {
            double valor;

            Console.Write("Insira o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Insira o Número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Haverá depósito inicial(s/n)? ");
            char sAux = char.Parse(Console.ReadLine());

            Conta c;

            if (sAux == 's' || sAux == 'S') {
                Console.Write("Digite o depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
                c = new Conta(conta, titular, valor);
            }
            else {
                c = new Conta(conta, titular);
            }

            Console.WriteLine("Dados da conta:\n" + c + "\n");

            Console.WriteLine("Digite o valor do depósito:");
            valor = double.Parse(Console.ReadLine());
            c.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados:\n " + c + "\n");

            Console.WriteLine("Digite o valor do saque:");
            valor = double.Parse(Console.ReadLine());
            c.Saque(valor);
            Console.WriteLine("Dados da conta atualizados:\n " + c);
        }
    }
}
