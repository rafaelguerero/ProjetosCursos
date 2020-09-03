using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PjIComparable.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vet = csvEmployee.Split(',');
            Name = vet[0];
            Salary = double.Parse(vet[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2",CultureInfo.InvariantCulture); 
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not a employee");
            }
            else
            {
                //Ordena a lista de funcionários pelo nome
                Employee other = obj as Employee;
                return Name.CompareTo(other.Name);
            }
        }
    }
}
