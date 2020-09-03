using System;
using System.Runtime.InteropServices;

namespace ExercProp3 {
    class Program {
        static void Main(string[] args) {

            /* Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
               incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
               impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
            string senha = "2200", senhadig;

            Console.WriteLine("Digite a senha");
            senhadig = Console.ReadLine();

            while (senhadig != senha) {
                Console.WriteLine("Senha inválida");
                Console.WriteLine("Digite a senha");
                senhadig = Console.ReadLine();
            }
            Console.WriteLine("Senha correta!"); */

            /*  Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
                um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
                4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
                que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
                mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
                exemplo.           
             */
            int countGas = 0, countAl = 0, countDi = 0;

            Console.Write("Digite o tipo de combustível (1- Álcool, 2- Gasolina, 3- Diesel, 4 - Fim): ");
            int comb = int.Parse(Console.ReadLine());

            while (comb != 4) {
                if (comb == 1) {
                    countAl++;
                }
                else if (comb == 2) {
                    countGas++;
                }
                else if (comb == 3) {
                    countDi++;
                }
                else {
                    Console.WriteLine("Código inválido!");
                }
               Console.Write("Digite o tipo de combustível (1- Álcool, 2- Gasolina, 3- Diesel, 4 - Fim): ");
               comb = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado!\n" + "Álcool: {0}\n" + "Gasolina: {1}\n" + "Diesel: {2}", countAl, countGas, countDi);
        }
    }
}
