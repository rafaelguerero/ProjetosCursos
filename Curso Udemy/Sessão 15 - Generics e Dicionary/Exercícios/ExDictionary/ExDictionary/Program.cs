using System;
using System.IO;
using System.Collections.Generic;

namespace ExDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\eleicao.txt";

            Dictionary<string, int> candidato = new Dictionary<string, int>();

            try
            {
                using StreamReader sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string[] c = sr.ReadLine().Split(',');
                    string name = c[0];
                    int votes = int.Parse(c[1]);

                    if (candidato.ContainsKey(name))
                    {
                        candidato[name] += votes;
                    }
                    else
                    {
                        candidato[name] = votes;
                    }
                }
                foreach (var item in candidato)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
