using System;
using System.Globalization;

namespace SaidaDados {
    class Program {
        static void Main(string[] args) {

            char genero = 'M';
            int idade = 28;
            double saldo = 2550.6087;
            string nome = "Rafael Guerero";

            /*
            Console.WriteLine(saldo.ToString("F2"));//arredonda para 2 casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));//imprime com o ponto
            */

            //Placeholder = lugar para entrar variáveis
            Console.WriteLine("{0}, do sexo {1}, tem {2} anos de idade e saldo de R${3}", nome, genero, idade, saldo.ToString("F2"));
            Console.WriteLine($"{nome}, do sexo {genero}, tem {idade} anos de idade e saldo de R${saldo:F2}");

            //Concatenar strings
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais.");
        }
    }
}
