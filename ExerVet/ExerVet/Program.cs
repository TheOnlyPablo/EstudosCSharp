using System;

namespace ExerVet
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Estudantes[] vet = new Estudantes[10];
            
            Console.Write("Quantos quartos serão alugados? ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel #{0}:", i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vet[quarto] = new Estudantes(nome, email);

            }
            Console.WriteLine("Quartos Ocupados: ");
            for (int j = 0; j < 10; j++)
            {
                if (vet[j] != null)
                {
                    Console.WriteLine(j + ": " + vet[j]);
                }
            }




        }
    }
}