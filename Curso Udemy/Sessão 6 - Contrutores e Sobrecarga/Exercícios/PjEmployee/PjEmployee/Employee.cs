using System;
using System.Collections.Generic;
using System.Text;

namespace PjEmployee {
    class Employee {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage) {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString() {
            return "ID: " + Id + "\n" + "Name: " + Name + "\n" + "Salary: " + Salary.ToString("F2");
        }
    }
}
