using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace ExerLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine("Employoee #{0}:", i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();

            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int findID = int.Parse(Console.ReadLine());

            ;

            Funcionario f = list.Find(x => x.Id == findID);
            if ( f != null)
            {
            Console.Write("Enter the percentage: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.increaseSalary(porcentagem);

            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}