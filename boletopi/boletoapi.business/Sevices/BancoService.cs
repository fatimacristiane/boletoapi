using boletoapi.business.Interfaces;
using boletoapi.business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boletoapi.business.Sevices
{
    public class BancoService : BaseService, IBancoService
    {
        private readonly IBancoRepository _bancoRepository;
        public BancoService(IBancoRepository bancoRepository, INotificador notificador) : base(notificador)
        {
            _bancoRepository = bancoRepository;
        }

        
        public async Task Adicionar(Banco banco)
        {
            if (!ExecutarValidacao(new BancoValidation(), banco)) return;

            await _bancoRepository.Adicionar(banco);
        }


        public void Dispose()
        {
            _bancoRepository?.Dispose();
        }

    }
}
