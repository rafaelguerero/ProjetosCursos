using System;
using System.Globalization;

namespace ExercicioProp {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            //Método 1: Com vários writelines, placeholder e concatenando string
            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo o preço é $ {1}", produto1, preco1.ToString("F2"));
            Console.WriteLine("{0}, cujo o preço é $ {1}", produto2, preco2.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + medida);
            Console.WriteLine("Arredondado (Três casas decimais): " + medida.ToString("F2"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();

            //Método 2: Com apenas 1 WriteLine e placeholder
            Console.WriteLine("Produtos:\n" +
                "{0}, cujo o preço é $ {1}\n" +
                "{2}, cujo o preço é $ {3}\n\n" +
                "Registro: {4} anos de idade, código {5} e gênero {6}\n\n" +
                "Medida com oito casas decimais: {7}\n" +
                "Arrendondado (Três casas decimais): {8}\n" +
                "Separador decimal invariant culture: {9}",
                    produto1, preco1.ToString("F2"), produto2, preco2.ToString("F2"),
                    idade, codigo, genero,
                    medida, medida.ToString("F2"), medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
