using ProjetoVendas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoVendas.Models;

namespace ProjetoVendas.Services
{
    public class DepartmentService
    {
        private readonly ProjetoVendasContext _context;

        public DepartmentService(ProjetoVendasContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
