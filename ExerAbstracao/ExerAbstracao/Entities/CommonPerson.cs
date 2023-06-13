using System;
using System.Collections.Generic;

namespace ExerAbstracao.Entities
{
    class CommonPerson : Pessoa 
    {
        public double HealthExpenses { get; set; }

        public CommonPerson(string name, double anualIncome, double healthExpenses)
            : base (name, anualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double PersonRate()
        {
            double total;
            if (AnualIncome < 20000.00)
            {
                total = (AnualIncome * 0.15) - (HealthExpenses * 0.5); 
                return total;
            }
            else
            {
                total = (AnualIncome * 0.25) - (HealthExpenses * 0.5);
                return total;
            }
        }



    }
}
