using _4Logic4Devs.Domain.Models;
using _4Logic4Devs.Repository.Interfaces;
using _4Logic4Devs.Services.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class AvaliacaoService : IAvaliacaoService
{
    private readonly IAvaliacaoRepository _avaliacaoRepository;
    private readonly IMapper _mapper;

    public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository, IMapper mapper)
    {
        _avaliacaoRepository = avaliacaoRepository;
        _mapper = mapper;
    }

    public async Task CreateAvaliacao(AvaliacaoDTO avaliacaoDto)
    {
        var avaliacao = _mapper.Map<Avaliacao>(avaliacaoDto);
        await _avaliacaoRepository.CreateAvaliacao(avaliacao);
    }

    public async Task<IEnumerable<AvaliacaoDTO>> GetAvaliacoes()
    {
        var avaliacoes = await _avaliacaoRepository.GetAvaliacoes();
        return _mapper.Map<IEnumerable<AvaliacaoDTO>>(avaliacoes);
    }

    public async Task<AvaliacaoDTO> GetAvaliacaoById(int id)
    {
        var avaliacao = await _avaliacaoRepository.GetAvaliacaoById(id);
        return _mapper.Map<AvaliacaoDTO>(avaliacao);
    }

    public async Task UpdateAvaliacao(int id, AvaliacaoDTO avaliacaoDto)
    {
        var avaliacao = _mapper.Map<Avaliacao>(avaliacaoDto);
        await _avaliacaoRepository.UpdateAvaliacao(id, avaliacao);
    }

    public async Task DeleteAvaliacao(int id)
    {
        await _avaliacaoRepository.DeleteAvaliacao(id);
    }




    public async Task<IEnumerable<Avaliacao>> GetDetalhesAvaliacao()
    {
        var avaliacao = await _avaliacaoRepository.GetAvaliacoesByClienteId();
        return avaliacao;
    }

    public double CalcularNPS(IEnumerable<Avaliacao> detalhes)
    {
        int total = detalhes.Count();
        int promotores = detalhes.Count(d => d.Nota >= 9);
        int detratores = detalhes.Count(d => d.Nota <= 6);

        return ((promotores - detratores) / (double)total) * 100;
    }
}
