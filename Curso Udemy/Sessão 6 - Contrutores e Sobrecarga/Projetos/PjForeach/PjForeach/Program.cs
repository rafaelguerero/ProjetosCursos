using System;

namespace PjForeach {
    class Program {
        static void Main(string[] args) {

            string[] vet = new string[] {"Maria", "João", "José" };

            foreach (string obj in vet) {
                Console.WriteLine(obj);
            }
        }
    }
}
