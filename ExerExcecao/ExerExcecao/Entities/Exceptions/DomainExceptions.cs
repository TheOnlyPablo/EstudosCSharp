using System;

namespace ExerExcecao.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message) { 
        }

    }
}
