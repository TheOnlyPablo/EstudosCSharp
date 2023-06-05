using System;


namespace ExerPOO3
{
    class Aluno
    {
        public string Nome;
        public double Tri1;
        public double Tri2;
        public double Tri3;

        public double NotaFinal()
        {
            return Tri1 + Tri2 + Tri3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() > 60.00)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }







    }
}
