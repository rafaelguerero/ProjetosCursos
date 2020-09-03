using System;
using System.Collections.Generic;
using System.Text;

namespace ExContract.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int mounths)
        {
            double interestValue = amount * 0.01;
            return amount + (interestValue * mounths);
        }

        public double PaymentFee(double amount)
        {
            return amount * 1.02;
        }
    }
}
