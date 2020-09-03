using System;
using System.Globalization;

namespace ExProp1 {
    class Program {
        static void Main(string[] args) {

            //1 - Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.

            /*double v1, v2, resultado;

            Console.WriteLine("Digite o primeiro valor:");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            v2 = double.Parse(Console.ReadLine());
            resultado = v1 + v2;
            Console.WriteLine("Resultado da soma: " + resultado.ToString("F2"));*/

            /*2 - Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
                Fórmula da área: area = π . raio2  Considere o valor de π = 3.14159 */

            /*double raio, area, pi = 3.14159;

            Console.WriteLine("Digite o valor do raio:");
            raio = double.Parse(Console.ReadLine());
            area = pi * Math.Pow(raio, 2);
            Console.WriteLine("Valor da área: " + area.ToString("F4", CultureInfo.InvariantCulture)); */

            /*3 - Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
              de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). */
            /*int a, b, c, d, dif;

            Console.WriteLine("Digite o valor de A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D:");
            d = int.Parse(Console.ReadLine());
            dif = a * b - c * d;
            Console.WriteLine("Diferença: " + dif);*/

            /*4 - Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais. */
            /*int num, horasTrab;
            double valorHora, salario;

            Console.WriteLine("Digite o número do funcionário:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor recebido por horas trabalhadas:");
            valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade de horas trabalhadas:");
            horasTrab = int.Parse(Console.ReadLine());
            salario = valorHora * horasTrab;
            Console.WriteLine("Número: {0}\n" + "Salário: {1}", num, salario.ToString("F2", CultureInfo.InvariantCulture));*/

            /*5 - Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. */
            /*string[] vet, vet2;
            int cod1, cod2, num1, num2;
            double valor1, valor2, resultado;

            Console.WriteLine("Código 1, Número 1, Valor 1:");
            vet = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vet[0]);
            num1 = int.Parse(vet[1]);
            valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Código 2, Número 2, Valor 2:");
            vet2 = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vet2[0]);
            num2 = int.Parse(vet2[1]);
            valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);
            resultado = num1 * valor1 + num2 * valor2;
            Console.WriteLine("Valor a pagar: " + resultado.ToString("F2", CultureInfo.InvariantCulture));*/

            /*6 - Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
                a) a área do triângulo retângulo que tem A por base e C por altura.
                b) a área do círculo de raio C. (pi = 3.14159)
                c) a área do trapézio que tem A e B por bases e C por altura.
                d) a área do quadrado que tem lado B.
                e) a área do retângulo que tem lados A e B. */

            string[] val;
            double a, b, c, tri, circ, trap, quad, ret, pi = 3.14159;
            Console.WriteLine("Valores A, B e C: ");
            val = Console.ReadLine().Split(' ');
            a = float.Parse(val[0], CultureInfo.InvariantCulture);
            b = float.Parse(val[1], CultureInfo.InvariantCulture);
            c = float.Parse(val[2], CultureInfo.InvariantCulture);
            tri = a * c / 2.0;
            circ = pi * Math.Pow(c, 2);
            trap = (a + b) / 2.0 * c;
            quad = b * b;
            ret = a * b;

            Console.WriteLine("Triângulo: {0}\n" + "Círculo: {1}\n" + "Trapézio: {2}\n" + "Quadrado: {3}\n" + "Retângulo: {4}", 
                tri.ToString("F2", CultureInfo.InvariantCulture), circ.ToString("F2", CultureInfo.InvariantCulture), trap.ToString("F2", CultureInfo.InvariantCulture), 
                quad.ToString("F2", CultureInfo.InvariantCulture), ret.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
