using System;

namespace PjMatriz {
    class Program {
        static void Main(string[] args) {

            /* Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo números inteiro. Em seguida, mostrar o valor da diagonal
             principal e a quantidade de valores negativos da matriz*/

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal princial:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }

            int count = 0;
            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Números negativos: " + count);
        }
    }
}
