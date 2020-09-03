using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Ret {
    public class Retangulo {

        //Propriedades
        public double altura, largura;

        //Métodos
        public double Area() {
            return altura * largura;
        }

        public double Perimetro() {
            return 2 * (altura + largura);
        }

        public double Diagonal() {
            double d;

            d = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));

            return d;
        }
    }
}
