using AutoMapper;
using boleto.api.DTO;
using boleto.data.Repository;
using boletoapi.business.Interfaces;
using boletoapi.business.Models;
using boletoapi.business.Sevices;
using Microsoft.AspNetCore.Mvc;

namespace boleto.api.Controllers
{
    [Route("api/bancos")]
    public class BancoController : ControllerBase
    {
        private readonly IBancoRepository _bancoRepository;
        private readonly IBancoService _bancoService;
        private readonly IMapper _mapper;

        public BancoController(
               IBancoRepository bancoRepository,
               IBancoService bancoService,
               IMapper mapper)
        {
            _bancoRepository = bancoRepository;
            _bancoService = bancoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<BancoDTO>> ObterTodos()
        {
            var banco = _mapper.Map<IEnumerable<BancoDTO>>(await _bancoRepository.ObterTodos());

            return banco;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<BancoDTO>> ObterPorId(Guid id)
        {
            var banco = _mapper.Map<BancoDTO>(await _bancoRepository.ObterPorId(id));

            if (banco == null) return NotFound();

            return Ok(banco);
        }


        [HttpPost]
        public async Task<ActionResult<BancoDTO>> Adcionar([FromBody]BancoDTO bancoDTO)
        {
            if (!ModelState.IsValid) { return BadRequest(); }

            await _bancoService.Adicionar(_mapper.Map<Banco>(bancoDTO));

            return NoContent();
        }
    }
}
