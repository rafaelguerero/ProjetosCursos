using System;
using System.Globalization;

namespace ExMembEstatic {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a cotação do dólar:");
            ConversorDeMoeda.cotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade de dólares a comprar:");
            ConversorDeMoeda.vlrDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor pago em reais: " + ConversorDeMoeda.ValorPgReais().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
