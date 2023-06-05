using System;


namespace ExerPOO4
{
    class ConversorDeMoedas
    {
        public static double Iof = 6.0;

        public static double Conversor(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;

        }

        
    }
}
