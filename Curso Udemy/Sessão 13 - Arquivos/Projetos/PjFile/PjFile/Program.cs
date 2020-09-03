using System;
using System.IO;

namespace PjFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Temp\file1.txt";
            string targetPath = @"c:\Temp\file2.txt";

            try
            {
                //Copia o arquivo 2 baseado no 1.
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                //Lê o conteudo do arquivo e armazena no vetor
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error as occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
