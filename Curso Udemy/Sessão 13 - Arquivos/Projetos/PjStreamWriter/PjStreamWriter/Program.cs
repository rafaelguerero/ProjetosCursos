using System;
using System.IO;

namespace PjStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Temp\file1.txt";
            string targetPath = @"c:\Temp\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
