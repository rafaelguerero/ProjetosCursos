using System;

namespace ExMatriz {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o número de linhas: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de colunas: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] mat = new int[linhas, colunas];

            InserirMatriz(linhas, colunas, mat);
            ListarMatriz(linhas, colunas, mat);

            Console.WriteLine("Digite um número para ser localizado na matriz");
            int num = int.Parse(Console.ReadLine());

            AchaPosicao(linhas, colunas, mat, num);
        }

        private static void InserirMatriz(int linhas, int colunas, int[,] mat) {
            for (int i = 0; i < linhas; i++) {
                string[] reg = Console.ReadLine().Split(" ");
                for (int j = 0; j < colunas; j++) {
                    mat[i, j] = int.Parse(reg[j]);
                }
            }
        }

        private static void ListarMatriz(int linhas, int colunas, int[,] mat) {
            Console.WriteLine("==================================================");
            string imprimir = "";
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    imprimir += mat[i, j] + " ";
                }
                imprimir += "\n";
            }
            Console.WriteLine(imprimir);
            Console.WriteLine("==================================================");
        }

        private static void AchaPosicao(int linhas, int colunas, int[,] mat, int num) {

            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    if (num == mat[i, j]) {
                        Console.WriteLine("Posição({0},{1})", i, j);
                        if (i > 0) {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if (i < linhas - 1) {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                        if (j > 0) {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]); ;
                        }
                        if (j < colunas - 1) {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
