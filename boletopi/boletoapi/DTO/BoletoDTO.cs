using boletoapi.business.Models;

namespace boleto.api.DTO
{
    public class BoletoDTO
    {
        public string NomePagador { get; set; }
        public string CPF_CNPJ_Pagador { get; set; }
        public string NomeBeneficiario { get; set; }
        public string CPF_CNPJ_Beneficiário { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Observacao { get; set; }

        public Banco Banco { get; set; }
    }
}
