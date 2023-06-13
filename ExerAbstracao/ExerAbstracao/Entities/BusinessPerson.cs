using System;
using System.Collections.Generic;


namespace ExerAbstracao.Entities
{
    class BusinessPerson : Pessoa
    {
        public int Employees { get; set; }

        public BusinessPerson(string name, double anualIncome, int employees) 
            : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double PersonRate()
        {
            if (Employees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
            
        }

    }
}
