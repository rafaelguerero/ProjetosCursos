using System;

namespace RefValor {
    class Program {
        static void Main(string[] args) {
            
            Point p;
            p.x = 10;
            p.y = 20;

            //permite a variável receber nulo
            double? z = null;

            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);

            Console.WriteLine(z.GetValueOrDefault());
            Console.WriteLine(z.HasValue);
        }
    }
}
