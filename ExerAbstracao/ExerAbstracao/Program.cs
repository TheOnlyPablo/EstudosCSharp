using System;
using System.Globalization;
using System.Collections.Generic;
using ExerAbstracao.Entities;
using System.Diagnostics.CodeAnalysis;

namespace ExerAbstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int pessoa = int.Parse(Console.ReadLine());

            List<Pessoa> list = new List<Pessoa>();

            for(int i = 1; i <= pessoa; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                { 
                    Console.Write("Health expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new CommonPerson(name, anualIncome, healthExpenses));

                } 
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new BusinessPerson(name, anualIncome, employees));

                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0;
            
            foreach (Pessoa p in list)
            {
                
                Console.WriteLine(p.Name + ": $ " + p.PersonRate().ToString("F2", CultureInfo.InvariantCulture));

                sum += p.PersonRate();
               

            }
                Console.WriteLine();
                Console.Write("TOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}