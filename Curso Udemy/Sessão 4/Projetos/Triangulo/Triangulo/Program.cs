using System;
using System.Globalization;

namespace Triangulo {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;

            //Instanciando
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os lados do Triângulo X: ");
            x.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoB  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os lados do Triângulo Y: ");
            y.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.CalcArea();
            double areaY = y.CalcArea();

            Console.WriteLine("Área X: {0}" + areaX.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Área Y: {0}" + areaY.ToString("F4"), CultureInfo.InvariantCulture);

            if (areaX > areaY) {
                Console.WriteLine("Maior área = X");
            }
            else {
                Console.WriteLine("Maior área = Y");
            }
        }
    }
}
