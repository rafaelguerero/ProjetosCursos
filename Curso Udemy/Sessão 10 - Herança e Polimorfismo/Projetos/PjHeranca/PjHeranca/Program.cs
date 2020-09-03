using PjHeranca.Entities;
using System;

namespace PjHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Account acc = new Account(1001, "Alex Green", 0);
            BusinessAccount bAcc = new BusinessAccount(7070, "Maria", 0, 500.00);

            //Upcasting
            Account acc1 = bAcc;
            Account acc2 = new BusinessAccount(4532, "Bob", 0, 1000.90);
            Account acc3 = new SavingsAccount(9631, "Anna", 0, 50.00);

            //Downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.50);
                Console.WriteLine("Loan");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }*/


            Account acc = new Account(1001, "Alex", 500 );
            Account acc2 = new SavingsAccount(1002, "Anna", 500, 0.01);
            acc.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
