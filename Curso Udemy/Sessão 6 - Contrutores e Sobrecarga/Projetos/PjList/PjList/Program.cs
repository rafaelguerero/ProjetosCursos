using System;
using System.Collections.Generic;

namespace PjList {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Rafael");
            list.Add("Ana");
            list.Add("Julia");
            list.Add("Adalton");
            list.Add("Raul");
            list.Insert(2, "Alex");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("Tamanho da lista: " + list.Count);

            //Expressão Lambda para retornar o primeiro elemento da lista que comece com A
            string s1 = list.Find(x => x[0] == 'A');

            string s2 = list.FindLast(x => x[0] == 'A');

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição começando com A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição começando com A: " + pos2);

            Console.WriteLine("--------------------------------------------------");
            List<string> list2 = list.FindAll(x => x.Length == 5); 

            foreach(string obj in list2) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------------------");

            list.Remove("Raul");
            list.RemoveAll(x => x[0] == 'J');
            list.RemoveAt(2);
            list.RemoveRange(2, 1);

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
