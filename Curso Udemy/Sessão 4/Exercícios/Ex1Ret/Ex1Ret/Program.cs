using System;

namespace Ex1Ret {
    class Program {
        static void Main(string[] args) {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Digite a altura:");
            ret.altura = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura:");
            ret.largura = Double.Parse(Console.ReadLine());

            Console.WriteLine("Área: " + ret.Area());
            Console.WriteLine("Perimetro: " + ret.Perimetro());
            Console.WriteLine("Diagonal: " + ret.Diagonal());
        }
    }
}
