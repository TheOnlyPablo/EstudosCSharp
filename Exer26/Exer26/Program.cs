using System;

namespace Exer26
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());

            if (x <= 50 && x > 25)
            {
                Console.WriteLine("Intervalo [25, 50]");
            } else if (x < 25 && x > 0) 
            {
                Console.WriteLine("Intervalo [0, 25]");
            }else if (x <= 100 && x > 75)
            {
                Console.WriteLine("Intervalo [75, 100]");
            }else
            {
                Console.WriteLine("Fora de invervalo");
            }
        }
    }
}
