﻿using System;
using System.Globalization;

namespace ExercicioFix
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1}", produto1, preco1);
            Console.WriteLine("{0}, cujo preco é $ {1}", produto2, preco2);
            Console.WriteLine("");
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine("");
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", media);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", media);
            Console.WriteLine("Separador decimal invariant culture: " + media.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}