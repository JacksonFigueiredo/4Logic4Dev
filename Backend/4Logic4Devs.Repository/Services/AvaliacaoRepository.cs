using _4Logic4Devs.Context;
using _4Logic4Devs.Domain.Models;
using _4Logic4Devs.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Logic4Devs.Repository.Services
{
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        private readonly ContextDB _context;

        public AvaliacaoRepository(ContextDB context)
        {
            _context = context;
        }

        public async Task CreateAvaliacao(Avaliacao avaliacao)
        {
            _context.Avaliacoes.Add(avaliacao);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Avaliacao>> GetAvaliacoes()
        {
            return await _context.Avaliacoes.ToListAsync();
        }

        public async Task<Avaliacao> GetAvaliacaoById(int id)
        {
            return await _context.Avaliacoes.FindAsync(id);
        }

        public async Task UpdateAvaliacao(int id, Avaliacao avaliacao)
        {
            _context.Entry(avaliacao).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAvaliacao(int id)
        {
            var avaliacao = await GetAvaliacaoById(id);
            if (avaliacao != null)
            {
                _context.Avaliacoes.Remove(avaliacao);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Avaliacao>> GetAvaliacoesByClienteId()
        {
            return await _context.Avaliacoes.ToListAsync();
        }
    }
}
