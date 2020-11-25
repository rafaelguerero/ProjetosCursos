using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoVendas.Data;
using ProjetoVendas.Models;

namespace ProjetoVendas.Services
{
    public class SellerService
    {
        private readonly ProjetoVendasContext _context;

        public SellerService(ProjetoVendasContext context)
        {
            _context = context;
        }

        //Retorna todos os vendedores
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
