using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using ExLinqEmp.Entities;

namespace ExLinqEmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho do arquivo: ");
            string path = Console.ReadLine();
            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, salary));
                    }
                }
                Console.WriteLine("E-mail dos funcionários com salário superior a: ");
                double auxSal = double.Parse(Console.ReadLine());
                IEnumerable<string> result1 = list.Where(p => p.Salary > auxSal).OrderBy(p => p.Email).Select(p => p.Email);
                double sum = list.Where(p => p.Name.StartsWith('M') == true).Select(p => p.Salary).DefaultIfEmpty(0).Sum();

                foreach (string l in result1)
                {
                    Console.WriteLine(l);
                }

                Console.WriteLine();
                Console.WriteLine("Soma dos funcionários com a letra M: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
                
            }
            catch (IOException e)
            {

                Console.WriteLine(e);
            }            
        }
    }
}
