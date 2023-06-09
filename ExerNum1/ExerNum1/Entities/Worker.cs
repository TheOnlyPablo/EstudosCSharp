using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using ExerNum1.Entities.Enums;

namespace ExerNum1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        
        public double BaseSalary { get; set; }
        
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();


        public Worker() 
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public void AddContract(HourContract contracts)
        {
            Contracts.Add(contracts);
        }

        public void RemoveContract(HourContract contracts)
        {
            Contracts.Remove(contracts);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }

    }
}
