using Microsoft.EntityFrameworkCore;
using ProjetoVendas.Data;
using ProjetoVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendas.Services
{
    public class SalesRecordService
    {
        private readonly ProjetoVendasContext _context;

        public SalesRecordService(ProjetoVendasContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result.Include(x => x.Seller).Include(x => x.Seller.Department).OrderByDescending(x => x.Date).ToListAsync();
        }
    }
}
