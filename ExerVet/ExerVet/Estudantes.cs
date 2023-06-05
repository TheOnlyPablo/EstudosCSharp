using System;


namespace ExerVet
{
    class Estudantes
    {
        public string Nome { set; get; }
        public string Email { set; get; }

        public Estudantes(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome 
                + ", " 
                + Email;
        }



    }
}
