using Microsoft.AspNetCore.Identity;
using ProEventos.Domain.Enums;
using System.Collections.Generic;

namespace ProEventos.Domain.Identity
{
    public class User : IdentityUser<int>
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public Titulo Titulo { get; set; }
        public string Descricao { get; set; }
        public Funcao Funcao { get; set; }
        public string ImagemUrl { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
    
}
