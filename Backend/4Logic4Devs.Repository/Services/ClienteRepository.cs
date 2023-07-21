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
    public class ClienteRepository : IClienteRepository
    {
        private readonly ContextDB _context;

        public ClienteRepository(ContextDB context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetByCnpjAsync(string cnpj)
        {
            return await _context.Clientes.FirstOrDefaultAsync(c => c.CNPJ == cnpj);
        }

        public async Task<Cliente> GetCliente(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task CreateCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCliente(int id, Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }
    }

}
