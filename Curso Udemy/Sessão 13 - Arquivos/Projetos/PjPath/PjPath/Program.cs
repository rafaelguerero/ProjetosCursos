using System;
using System.IO;

namespace PjPath
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\file1.txt";

            try
            {
                Console.WriteLine("Separator char: " + Path.DirectorySeparatorChar);
                Console.WriteLine("Path separator: " + Path.DirectorySeparatorChar);
                Console.WriteLine("Get Directory name: " + Path.GetDirectoryName(path));
                Console.WriteLine("GetFileName: " + Path.GetFileName(path));
                Console.WriteLine("File Name: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("Extension: " + Path.GetExtension(path));
                Console.WriteLine("Get Full Path: " + Path.GetFullPath(path));
                Console.WriteLine("Temp Path: " + Path.GetTempPath());
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
