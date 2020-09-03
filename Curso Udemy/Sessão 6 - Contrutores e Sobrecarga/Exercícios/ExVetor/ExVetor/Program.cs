using System;

namespace ExVetor {
    class Program {
        static void Main(string[] args) {


            Estudante[] vetQuarto = new Estudante[10];

            Console.Write("Digite a quantidade de aluguéis: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < n; i++) {

                Console.WriteLine("Nome");
                string nome = Console.ReadLine();

                Console.WriteLine("E-mail");
                string email = Console.ReadLine();

                Console.WriteLine("Quarto");
                int quarto = int.Parse(Console.ReadLine());

                vetQuarto[quarto] = new Estudante {Nome = nome, Email = email };
                Console.WriteLine();
            }

            int count = 1;
            for (int i = 0; i < 10; i++) {
                
                if (vetQuarto[i] != null) {
                    Console.WriteLine("Aluguel #" + count);
                    Console.WriteLine("Nome: " + vetQuarto[i].Nome);
                    Console.WriteLine("E-mail: " + vetQuarto[i].Email);
                    Console.WriteLine("Quarto: " + i);
                    count++;
                    Console.WriteLine();
                }
            }
        }
    }
}
