using _4Logic4Devs.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Logic4Devs.Repository.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetClientes();
        Task<Cliente> GetCliente(int id);
        Task CreateCliente(Cliente cliente);
        Task UpdateCliente(int id, Cliente cliente);
        Task DeleteCliente(int id);
        Task<Cliente> GetByCnpjAsync(string cnpj);
    }

}
