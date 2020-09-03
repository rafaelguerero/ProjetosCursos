using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ExEmployee.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double aditionalCharge) : base(name, hours, valuePerHour)
        {
            AditionalCharge = aditionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AditionalCharge;
        }
    }
}
