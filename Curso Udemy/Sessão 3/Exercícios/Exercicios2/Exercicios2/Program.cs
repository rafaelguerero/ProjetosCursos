using System;

namespace Exercicios2 {
    class Program {
        static void Main(string[] args) {

            /*  Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
                Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em      
                ordem crescente ou decrescente.
            

            int v1, v2;

            Console.WriteLine("Digite o primeiro valor...");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor...");
            v2 = int.Parse(Console.ReadLine());

            if ( v1 % v2 == 0 || v2 % v1 == 0) {
                Console.WriteLine("São multiplos");
            }
            else {
                Console.WriteLine("Não são multiplos");
            } */

            /*  Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
                começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas. 
            */

            int hr1, hr2, duracao; 

            Console.WriteLine("Hora inicial:");
            hr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hora final:");
            hr2 = int.Parse(Console.ReadLine());

            if ((hr1 > 0 && hr1 <= 24 ) && (hr2 > 0 && hr2 <= 24)){
                if (hr1 < hr2) {
                    duracao = hr2 - hr1;
                }
                else {
                    duracao = 24 - hr1 + hr2;
                }
                Console.WriteLine("Duração: {0}", duracao);
            }
            else {
                Console.WriteLine("Hora inválida");
            }
        }
    }
}
