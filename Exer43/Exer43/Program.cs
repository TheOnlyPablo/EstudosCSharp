using System;
using System.Globalization;

namespace Exer43
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double[] vetor = {1};

            int j = 0;

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double x1 = double.Parse(vet[0]);
                double x2 = double.Parse(vet[1]);
                double x3 = double.Parse(vet[2]);

                double media = (x1 * 2 + x2 * 3 + x3 * 5) / 10;

                vetor[j] = media ;

                j++;
                

            }
            
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            
        }
    }
}
