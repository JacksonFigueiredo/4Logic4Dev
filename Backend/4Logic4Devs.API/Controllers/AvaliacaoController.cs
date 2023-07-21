using _4Logic4Devs.Domain.Models;
using _4Logic4Devs.Services.Interfaces;
using _4Logic4Devs.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _4Logic4Devs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoController : ControllerBase
    {
        private readonly IAvaliacaoService _avaliacaoService;
        private readonly IClienteService _clienteService;

        public AvaliacaoController(IAvaliacaoService avaliacaoService, IClienteService clienteService)
        {
            _avaliacaoService = avaliacaoService;
            _clienteService = clienteService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Avaliacao>> GetAll()
        {
            return Ok(_avaliacaoService.GetAvaliacoes());
        }

        [HttpGet("{id}")]
        public ActionResult<Avaliacao> GetById(int id)
        {
            var avaliacao = _avaliacaoService.GetAvaliacaoById(id);
            if (avaliacao == null)
            {
                return NotFound();
            }
            return Ok(avaliacao);
        }

        [HttpPost]
        public ActionResult<Avaliacao> Add(AvaliacaoDTO avaliacao)
        {
            _avaliacaoService.CreateAvaliacao(avaliacao);
            return CreatedAtAction(nameof(GetById), new { id = avaliacao.Id }, avaliacao);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, AvaliacaoDTO avaliacao)
        {
            if (id != avaliacao.Id)
            {
                return BadRequest();
            }

            _avaliacaoService.UpdateAvaliacao(id, avaliacao);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _avaliacaoService.DeleteAvaliacao(id);
            return NoContent();
        }

        [HttpGet("nps")]
        public async Task<IActionResult> GetNPS()
        {
            var detalhe = await _avaliacaoService.GetDetalhesAvaliacao();
            var nps = _avaliacaoService.CalcularNPS(detalhe);

            return Ok(new { detalhe, nps });
        }

    }
}

