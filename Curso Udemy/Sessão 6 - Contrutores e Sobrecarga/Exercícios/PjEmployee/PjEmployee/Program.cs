using System;
using System.Collections.Generic;

namespace PjEmployee {
    class Program {
        static void Main(string[] args) {

            List<Employee> list = new List<Employee>();

            Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            InsertEmployee(n, list);

            ListEmployee(list);

            UpdateSalary(list);

            ListEmployee(list);
        }

        private static void InsertEmployee(int amount, List<Employee> list) {

            for (int i = 0; i < amount; i++) {
                Console.WriteLine("Enter a ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter a Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
        }

        private static void ListEmployee(List<Employee> list) {
            Console.WriteLine();
            int count = 1;
            foreach (Employee obj in list) {
                Console.WriteLine("Employee#" + count);
                Console.WriteLine(obj);
                count++;
                Console.WriteLine();
            }
        }

        private static void UpdateSalary(List<Employee> list) {

            Console.WriteLine("Enter the ID of the employee who will have salary increased: ");
            int idEmp = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == idEmp);

            if (emp != null) {
                Console.WriteLine("Enter the percentage:");
                double perc = double.Parse(Console.ReadLine());

                emp.IncreaseSalary(perc);
            }
            else {
                Console.WriteLine("Employee not found!");
            }
        }
    }
}
