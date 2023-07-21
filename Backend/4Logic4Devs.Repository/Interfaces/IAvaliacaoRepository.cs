using _4Logic4Devs.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Logic4Devs.Repository.Interfaces
{
    public interface IAvaliacaoRepository
    {
        Task CreateAvaliacao(Avaliacao avaliacao);
        Task<IEnumerable<Avaliacao>> GetAvaliacoes();
        Task<Avaliacao> GetAvaliacaoById(int id);
        Task UpdateAvaliacao(int id, Avaliacao avaliacao);
        Task DeleteAvaliacao(int id);
        Task<IEnumerable<Avaliacao>> GetAvaliacoesByClienteId();

    }
}
