using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExPayers.Entities
{
    class Individual: Payer
    {
        public double HeathExpend { get; set; }

        public Individual(string name, double anualIncome, double heathExpend):base(name, anualIncome)
        {
            HeathExpend = heathExpend;
        }

        public override double TaxesPaid()
        {
            double taxe;
            if (AnualIncome >= 20000.00)
            {
                taxe = 0.25;
            }
            else
            {
                taxe = 0.15;
            }

            return (AnualIncome * taxe) - (HeathExpend * 0.50);
        }

        public override string ToString()
        {
            return Name + ": $" + TaxesPaid().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
