using System;
using System.Collections.Generic;
using System.Text;

namespace ExercEmplyer.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }


        public OutsourceEmployee()
        {
        }

        public OutsourceEmployee(string name, int hours, double valuerPerHour, double additionalCharge) 
            : base (name, hours, valuerPerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
