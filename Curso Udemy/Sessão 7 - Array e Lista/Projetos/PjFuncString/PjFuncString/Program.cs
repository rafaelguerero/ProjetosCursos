using System;

namespace PjFuncString {
    class Program {
        static void Main(string[] args) {

            string original = "  Rafael Michelini Guerero";

            //Verifica se a string é nula ou vazia
            bool b1 = String.IsNullOrEmpty(original);
            //Testa se é nula ou espaço em branco
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine(original);
            Console.WriteLine(original.ToUpper());
            Console.WriteLine(original.ToLower());
            Console.WriteLine(original.Trim());
            Console.WriteLine(original.IndexOf("Raf"));
            Console.WriteLine(original.LastIndexOf('e'));
            Console.WriteLine(original.Substring(9, 15));
            Console.WriteLine(original.Replace('a', 'x'));
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }
}
