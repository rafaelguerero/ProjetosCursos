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

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
