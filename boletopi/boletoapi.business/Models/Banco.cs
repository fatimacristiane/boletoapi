using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boletoapi.business.Models
{

    public class Banco : Entity
    {
        public string Nome { get; set; }
        public string Cadigo { get; set; }
        public decimal PercentualJuros { get; set; }

        public IEnumerable<Boleto> Boletos { get; set; }
    }   
}
   

