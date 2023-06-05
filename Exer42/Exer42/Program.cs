using System;
using System.Security.Cryptography.X509Certificates;

namespace Exer42
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int var_in = 0;
            int var_out = 0;

            for (int i = 0; i<n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x < 10 || x > 20)
                {
                    var_out++;
                }
                else
                {
                    var_in++;
                }

            }
            
            Console.WriteLine("{0} in", var_in);
            Console.WriteLine("{0} out", var_out);

        }
    }
}