using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            SByte x = 100;
            byte n1 = 255;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 45.6F;
            double n6 = 78.9;
            string nome = "Rafael";
            object obj1 = "Guerero";
            object obj2 = 4.5F;
            int num = int.MaxValue;


            bool completo = false;
            char genero = 'M';

            //Overflow: Quando um cálculo estrapola o valor da variável
            //cw + tab tab: preenche automático

            Console.WriteLine("O valor é: " + n2);
            Console.WriteLine(n1);
            Console.WriteLine(x);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(num);
        }
    }
}
