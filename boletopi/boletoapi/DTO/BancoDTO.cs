using boletoapi.business.Models;

namespace boleto.api.DTO
{
    public class BancoDTO
    {
        public string Nome { get; set; }
        public string Cadigo { get; set; }
        public decimal PercentualJuros { get; set; }

        public IEnumerable<Boleto>? Boletos { get; set; }
    }
}
