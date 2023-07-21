using _4Logic4Devs.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Logic4Devs.Services.Interfaces
{
    public interface IAvaliacaoService
    {
        Task CreateAvaliacao(AvaliacaoDTO avaliacaoDto);
        Task<IEnumerable<AvaliacaoDTO>> GetAvaliacoes();
        Task<AvaliacaoDTO> GetAvaliacaoById(int id);
        Task UpdateAvaliacao(int id, AvaliacaoDTO avaliacaoDto);
        Task DeleteAvaliacao(int id);
        double CalcularNPS(IEnumerable<Avaliacao> detalhes);
        Task<IEnumerable<Avaliacao>> GetDetalhesAvaliacao();
    }
}

