using ProjetoVendas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoVendas.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoVendas.Services
{
    public class DepartmentService
    {
        private readonly ProjetoVendasContext _context;

        public DepartmentService(ProjetoVendasContext context)
        {
            _context = context;
        }

        //Método Assíncrono
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
