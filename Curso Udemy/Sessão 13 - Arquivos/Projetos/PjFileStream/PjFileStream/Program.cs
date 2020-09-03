using System;
using System.IO;

namespace PjFileStream
{
    class Program
    {
        static void Main(string[] args)
        {            
            StreamReader sr = null;
            string path = @"c:\Temp\file1.txt";
            try
            {
                sr = File.OpenText(path);
                
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }                
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }                
            }
        }
    }
}
