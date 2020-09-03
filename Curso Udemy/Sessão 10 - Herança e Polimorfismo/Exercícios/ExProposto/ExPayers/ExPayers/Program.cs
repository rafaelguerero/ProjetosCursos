using ExPayers.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExPayers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} Data");
                Console.Write("Individual or Company(i/c): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i' || type == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double expend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, expend));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double sum = 0.0;

            foreach (Payer payer in list)
            {
                Console.WriteLine(payer.ToString());
                sum += payer.TaxesPaid();
            }
            Console.WriteLine("Total taxes: $" + sum, CultureInfo.InvariantCulture);
        }
    }
}
