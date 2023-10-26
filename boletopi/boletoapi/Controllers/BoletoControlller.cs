using AutoMapper;
using boleto.api.DTO;
using boletoapi.business.Interfaces;
using boletoapi.business.Models;
using Microsoft.AspNetCore.Mvc;

namespace boleto.api.Controllers
{
    [Route("api/boletos")]
    public class BoletoControlller : ControllerBase
    {
        private readonly IBoletoRepository _boletoRepository;
        private readonly IBoletoService _boletoService;
        private readonly IMapper _mapper;

        public BoletoControlller(
           IBoletoRepository boletoRepository,
           IBoletoService boletoService,
           IMapper mapper)
        {
            _boletoRepository = boletoRepository;
            _boletoService = boletoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<BoletoDTO>> ObterTodos()
        {
            var boleto = _mapper.Map<IEnumerable<BoletoDTO>>(await _boletoRepository.ObterTodos());

            return boleto;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<BoletoDTO>> ObterPorId(Guid id)
        {
            var boleto = _mapper.Map<BoletoDTO>(await _boletoRepository.ObterPorId(id));

            if (boleto == null) return NotFound();

            return Ok(boleto);
        }


        [HttpPost]
        public async Task<ActionResult<BoletoDTO>> Adcionar([FromBody]BoletoDTO boletoDTO)
        {
            if (!ModelState.IsValid) {  return BadRequest(); }

             await _boletoService.Adicionar(_mapper.Map<Boleto>(boletoDTO));

            return NoContent();
        }

    }

}
