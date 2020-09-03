using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex3NotaAluno {

    class Aluno {
        public string nome;
        public double n1, n2, n3;

        public double NotaFinal() {
            return n1 + n2 + n3;
        }

        public string Situacao() {
            double nota = NotaFinal(), media = 60;

            if (nota >= media) {
                return "Aprovado";
            }
            else {
                nota = media - nota;
                return "Reprovado, faltaram " + nota.ToString("F2", CultureInfo.InvariantCulture) + " pontos";
            }            
        }
    }
}
