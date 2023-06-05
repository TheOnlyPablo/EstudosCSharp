using System;

namespace Exer31
{
    class Program
    {
        static void Main(string[] args)
        {
           int Tentsenha = int.Parse(Console.ReadLine());
           
            
            while(Tentsenha != 2002) 
            {
                Console.WriteLine("Senha Invalida");
                Tentsenha = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Acesso Permitido");







        }
    }
}
