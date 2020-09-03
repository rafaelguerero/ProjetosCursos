using ExArquivo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ExArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sourcePath = @"c:\temp\product.csv";
                string destinyPath = @"c:\temp\Out\";
                string fileName = destinyPath + "summary.csv";

                if (!Directory.Exists(destinyPath))
                {
                    Directory.CreateDirectory(destinyPath);
                }

                string[] lines = File.ReadAllLines(sourcePath);

                if (!File.Exists(fileName))
                {
                    using StreamWriter sw = File.AppendText(fileName);
                    foreach (string l in lines)
                    {
                        string[] fields = l.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);
                        Product prod = new Product(name, price, quantity);
                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                    
                    Console.WriteLine("File created.");
                }
                else                {
                    
                    Console.WriteLine("The file already exists.");
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
