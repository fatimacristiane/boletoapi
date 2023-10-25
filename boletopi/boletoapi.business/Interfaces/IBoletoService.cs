using boletoapi.business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boletoapi.business.Interfaces
{
    public interface IBoletoService : IDisposable
    {
       Task Adicionar(Boleto boleto);
    }
}
