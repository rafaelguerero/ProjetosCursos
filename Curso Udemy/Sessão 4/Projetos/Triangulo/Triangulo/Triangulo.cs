using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulo {
    class Triangulo {

        public double LadoA, LadoB, LadoC;

        public double CalcArea() {
            double p;

            p = (LadoA + LadoB + LadoC) / 2;
            return Math.Sqrt(p * (p - LadoA) * (p - LadoC) * (p - LadoC));
        }
    }
}
