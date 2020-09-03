using System;
using System.Globalization;

namespace MembroEstatico {
    class Program {        

        static void Main(string[] args) {
           

            Console.WriteLine("Digite o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Chama os métodos pelo nome da classe
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Volume: " + volume.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Pi: " + Calculadora.pi.ToString("F2"), CultureInfo.InvariantCulture);
        }

    }
}
