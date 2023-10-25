using boletoapi.business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boletoapi.business.Interfaces
{
    public interface IBancoRepository : IRepository<Banco>
    {
        Task Adicionar(Boleto boleto);

        Task<List<Boleto>> ObertObterTodos();
    }
}
