using System;

namespace CondicionalIfElse {
    class Program {
        static void Main(string[] args) {

            /*Console.WriteLine("Digite um número inteiro:");
            int x = int.Parse(Console.ReadLine());

            if ( x % 2 == 0) {
                Console.WriteLine("Par");
            }
            else {
                Console.WriteLine("Ímpar");
            }*/

            Console.WriteLine("Digite a hora atual:");
            int h = int.Parse(Console.ReadLine());

            if (h < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if( h < 18){
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}
