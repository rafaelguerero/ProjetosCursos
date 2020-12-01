using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoVendas.Models;
using ProjetoVendas.Models.Enums;

namespace ProjetoVendas.Data
{
    //Serviço responsável por popular o banco de dados
    public class SeedingService
    {
        private ProjetoVendasContext _context;

        public SeedingService(ProjetoVendasContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //Verifica se exite registro na base de dados
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;//O banco de dados já foi populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1992, 4, 21), 3000, d1);
            Seller s2 = new Seller(2, "Maria Green", "mgreen@gmail.com", new DateTime(1998, 10, 10), 4200, d3);
            Seller s3 = new Seller(3, "Ana Red", "ana@gmail.com", new DateTime(2000, 1, 3), 3000, d4);
            Seller s4 = new Seller(4, "Marcos Blue", "mblue@gmail.com", new DateTime(1992, 4, 21), 3800, d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2020, 11, 23), 11000, SalesStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2020, 10, 1), 5000, SalesStatus.Canceled, s1);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2020, 10, 5), 21000, SalesStatus.Billed, s2);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2020, 9, 20), 9600, SalesStatus.Billed, s3);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2020, 11, 20), 8000, SalesStatus.Billed, s4);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2020, 10, 30), 6650, SalesStatus.Pending, s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6);

            _context.SaveChanges();
        }
    }
}
