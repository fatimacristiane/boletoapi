using boleto.data.Context;
using boletoapi.business.Interfaces;
using boletoapi.business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace boleto.data.Repository
{
    public class BoletoRepository : Repository<Boleto>, IBoletoRepository
    {
        public BoletoRepository(MeuDbContext context) : base(context)
        {

        }

        public async Task<List<Boleto>> ObertTodos()
        {
            return await Db.Boletos.AsNoTracking()
                .Include(c => c.Banco)
                .OrderBy(c => c.NomePagador)
                .ToListAsync();
            
        }
    }
}
