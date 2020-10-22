using System;
using PjDelegate.Services;

namespace PjDelegate
{
    //Delegate
    internal delegate double BinaryNumericOperation(double n1, double n2);
    //Multicast Delegate
    internal delegate void BinaryNumericOp(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOp ope = CalculationService.ShowSum;
            ope += CalculationService.ShowMax;

            //double result = op(a, b);
            double result = op.Invoke(a, b);
            ope.Invoke(a, b);

            Console.WriteLine(result);            
        }
    }
}
