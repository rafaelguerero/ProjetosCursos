using ExContract.Entities;
using ExContract.Services;
using System;

namespace ExContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());

            Contract c = new Contract(number, date, value);

            Console.WriteLine("Enter number of installments: ");
            int numberInst = int.Parse(Console.ReadLine());

            ContractService cs = new ContractService(new PaypalService());
            cs.ProcessContract(c, numberInst);

            Console.WriteLine("Installments: ");
            foreach (Installment inst in c.Installments)
            {
                Console.WriteLine(inst.ToString());
            }
        }
    }
}
