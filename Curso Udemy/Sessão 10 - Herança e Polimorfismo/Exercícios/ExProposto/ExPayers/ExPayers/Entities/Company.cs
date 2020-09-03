using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExPayers.Entities
{
    class Company : Payer
    {
        public int Employees { get; set; }

        public Company(string name, double anualIncome, int employees) : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double TaxesPaid()
        {
            double taxe;
            if (Employees > 10)
            {
                taxe = 0.14;
            }
            else
            {
                taxe = 0.16;
            }

            return AnualIncome * taxe;
        }

        public override string ToString()
        {
            return Name + ": $" + TaxesPaid().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
