using System;
using System.IO;

namespace PjUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                };

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
