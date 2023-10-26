using boleto.data.Context;
using boletoapi.business.Interfaces;
using boletoapi.business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleto.data.Repository
{
    public class BancoRepository : Repository<Banco>, IBancoRepository
    {
        public BancoRepository(MeuDbContext context) : base(context)
        {
            
        }
     
        public async Task<List<Banco>> ObertTodos()
        {
            return await Db.Bancos.AsNoTracking()
                .Include(c => c.Boletos)
                .OrderBy(c => c.Nome)
                .ToListAsync();
        }
    }
}
