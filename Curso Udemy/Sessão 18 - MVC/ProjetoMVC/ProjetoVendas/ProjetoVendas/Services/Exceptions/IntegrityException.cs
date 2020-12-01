using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendas.Services.Exceptions
{
    public class IntegrityException: ApplicationException
    {
        public IntegrityException(string message) : base(message) 
        {
        }
        
    }
}
