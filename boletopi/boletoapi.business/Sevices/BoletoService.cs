using boletoapi.business.Interfaces;
using boletoapi.business.Models;
using boletoapi.business.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace boletoapi.business.Sevices
{
    public class BoletoService : BaseService, IBoletoService
    {
        private readonly IBoletoRepository _boletoRepository;
        private readonly IBancoRepository _bancoRepository;
        public BoletoService(IBoletoRepository boletoRepository, IBancoRepository bancoRepository, INotificador notificador) : base(notificador)
        {
            _bancoRepository = bancoRepository;
            _boletoRepository = boletoRepository;
        }

        public  async Task Adicionar(Boleto boleto)
        {
            if(!ExecutarValidacao(new BoletoValidation(), boleto) || ! ExecutarValidacao(new BancoValidation(), boleto.Banco)) return;

            await _boletoRepository.Adicionar(boleto);
        }

        public void Dispose()
        {
            _bancoRepository?.Dispose();
            _boletoRepository?.Dispose();
        }

    }
}
