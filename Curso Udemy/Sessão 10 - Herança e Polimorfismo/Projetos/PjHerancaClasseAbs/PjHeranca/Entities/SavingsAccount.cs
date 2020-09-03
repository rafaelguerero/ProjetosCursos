using System;
using System.Collections.Generic;
using System.Text;

namespace PjHeranca.Entities
{
    //sealed: previne que a classe seja herdada
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate): base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Sobrescrevo o método Withdraw da classe Account
        //sealed: o método não pode ser sobreposto novamente em outra classe
        public sealed override void Withdraw(double amount)
        {
            //Faz conforme a regra da superclasse
            base.Withdraw(amount);
            Balance -= 2.0;
        }

    }
}
