using ExAccount.Entities;
using ExAccount.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, limit);
                Console.WriteLine();

                Console.Write("deposit or withdraw? d/w: ");
                char op = char.Parse(Console.ReadLine());
                double amount;
                if (op == 'd' || op == 'D')
                {
                    Console.Write("Enter amount for deposit: ");
                    amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    acc.Deposit(amount);
                }
                else
                {
                    Console.Write("Enter amount for withdraw: ");
                    amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    acc.Withdraw(amount);
                }
                Console.WriteLine("New balance: $" + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException d)
            {
                Console.WriteLine(d);
            }
            catch (FormatException f)
            {
                Console.WriteLine(f);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
