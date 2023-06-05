using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, pi = 3.14159, resultado;

            r = double.Parse(Console.ReadLine());

            resultado = pi * r * r;

            Console.WriteLine(resultado.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}

