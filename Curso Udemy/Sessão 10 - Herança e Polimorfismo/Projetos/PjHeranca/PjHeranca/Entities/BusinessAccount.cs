using System;
using System.Collections.Generic;
using System.Text;

namespace PjHeranca.Entities
{
    //Extende a classe conta
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        //base() : reaproveita os construtores da classe Account
        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan (double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }            
        }
    }
}
