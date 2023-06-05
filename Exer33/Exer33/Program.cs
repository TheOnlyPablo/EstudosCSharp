using System;

namespace Exer33
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod = int.Parse(Console.ReadLine());
            int gas = 0;
            int alcool = 0;
            int disel = 0;


            while (cod != 4)
            {
                if (cod == 1)
                {
                    alcool++;
                }
                else if (cod == 2)
                {
                    gas++;
                }
                else if (cod == 3)
                {
                    disel++;
                }
                else if (cod == 4)
                {
                    break;
                }

                cod = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: {0}", alcool);
            Console.WriteLine("Gasolina: {0}", gas);
            Console.WriteLine("Diesel: {0}", disel);
        }
    }
}