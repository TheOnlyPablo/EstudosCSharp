using System;
using System.Collections.Generic;


namespace ExerAbstracao.Entities
{
    abstract class Pessoa
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Pessoa() { }

        public Pessoa(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double PersonRate();


    }
}
