using System;


namespace ExerPolimorfismo.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }
        
        public OutsourcedEmployee(string name, int hours, double valuePerHour, 
            double additionalcharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalcharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
