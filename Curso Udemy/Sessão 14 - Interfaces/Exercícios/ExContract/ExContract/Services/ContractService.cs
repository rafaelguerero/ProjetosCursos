using ExContract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExContract.Services
{
    class ContractService
    {
        private IOnlinePaymentService OnlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            OnlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double instAmount = Math.Round(contract.TotalValue / months, 2);
            double dueValue;
            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                dueValue = OnlinePaymentService.Interest(instAmount, i);
                dueValue = OnlinePaymentService.PaymentFee(dueValue);

                Installment installment = new Installment(dueDate, dueValue);
                
                contract.AddInstallment(installment);
            }
        }
    }
}
