using PjHeranca.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace PjHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mesmo sendo classe abstrata, ela pode ser tipo de uma lista
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Maria", 500, 0.01));
            list.Add(new BusinessAccount(1002, "Bob", 600, 200));
            list.Add(new SavingsAccount(1003, "John", 1000, 0.08));
            list.Add(new BusinessAccount(1004, "Rita", 1000.85, 400));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2",CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.00);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Acc number: " + acc.Number + "\n" + "Acc balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture) + "\n");
            }
        }
    }
}
