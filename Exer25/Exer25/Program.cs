using System;
using System.Globalization;

namespace Exer25
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            
            int codItem = int.Parse(valores[0]);
            int quantItem = int.Parse(valores[1], CultureInfo.InvariantCulture);

            if (codItem == 1)
            {
                double preco = 4.00 * quantItem;
                Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            }else if (codItem == 2) {

                double preco = 4.50 * quantItem;
                Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codItem == 3)
            {
                double preco = 5.00 * quantItem;
                Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            }else if (codItem == 4)
            {
                double preco = 2.00 * quantItem;
                Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codItem == 5)
            {
                double preco = 1.50 * quantItem;
                Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}