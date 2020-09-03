using System;
using System.Globalization;


namespace EntradaDados {
    class Program {
        static void Main(string[] args) {

            /*string frase = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine(frase);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);*/

            int n1 = int.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            char ch = char.Parse(Console.ReadLine());

            //Faz a leitura da linha inteira, inserindo em um vetor e separado por espaço
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ch);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
