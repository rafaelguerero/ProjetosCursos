using System;

namespace ExProp4 {
    class Program {
        static void Main(string[] args) {

            /* 1- Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
                  X, se for o caso.

            Console.WriteLine("Digite um número inteiro:");
            int x = int.Parse(Console.ReadLine());

            for(int i = 1; i <= x; i++) {

                if ( i % 2 == 1) {
                    Console.WriteLine(i);
                }
            } * /

            /* 2- Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
                  Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
                  essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            int countIN = 0, countOut = 0, vlDig;

            Console.WriteLine("Digite a quandidade de valores:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                vlDig = int.Parse(Console.ReadLine());

                if (vlDig >= 10 && vlDig <= 20) {
                    countIN++;
                }
                else {
                    countOut++;
                }
            }

            Console.WriteLine("{0} IN; {1} OUT", countIN, countOut); */

            /* 4- Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
                  segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
            
            string[] vet;
            double v1, v2;

            Console.WriteLine("Digite a quantidade de divisões");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) {
                Console.Write("Digite os valores: ");
                vet = Console.ReadLine().Split(" ");
                v1 = double.Parse(vet[0]);
                v2 = double.Parse(vet[1]);
                
                if (v2 == 0) {
                    Console.WriteLine("Divisão impossível");
                }
                else {
                    // Discard, não necessita de variável
                    Console.WriteLine(_ = v1 / v2); 
                }                
            }*/

            /* 5 - Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
                    Lembrando que, por definição, fatorial de 0 é 1.
            
            long fat = 1;
            Console.WriteLine("Digite a quantidade de divisões");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) {
                fat *= i;
            }
            Console.WriteLine("Fatorial: {0}", fat); */

            /*6- Ler um número inteiro N e calcular todos os seus divisores. */
            Console.WriteLine("Digite um número");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++) {
                if (num % i == 0) {
                    Console.WriteLine(i);
                }
            }

        }

    }
}
