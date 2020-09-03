using System;
using System.Collections.Generic;
using System.Text;

namespace ExMembEstatic {
    class ConversorDeMoeda {
        public static double vlrDolar, cotDolar, percIOF = 1.06;

        public static double ValorPgReais() {
            double valor;

            valor = vlrDolar * cotDolar *  percIOF;

            return valor;
        }

    }
}
