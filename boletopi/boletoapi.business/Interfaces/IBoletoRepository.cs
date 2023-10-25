using boletoapi.business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boletoapi.business.Interfaces
{
    public interface IBoletoRepository : IRepository<Boleto>
    {
        Task Adicionar(Boleto boleto);

        Task<Boleto> ObterPorId(Guid id);

        Task<List<Boleto>> ObertObterTodos();
    }

}
