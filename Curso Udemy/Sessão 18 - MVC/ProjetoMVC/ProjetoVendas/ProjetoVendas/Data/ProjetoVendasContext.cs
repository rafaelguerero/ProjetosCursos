using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoVendas.Models;

namespace ProjetoVendas.Data
{
    public class ProjetoVendasContext : DbContext
    {
        public ProjetoVendasContext (DbContextOptions<ProjetoVendasContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoVendas.Models.Department> Department { get; set; }
    }
}
