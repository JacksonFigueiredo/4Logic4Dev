using _4Logic4Devs.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Logic4Devs.Services.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteDTO>> GetClientes();
        Task<ClienteDTO> GetCliente(int id);
        Task<ClienteDTO> CreateCliente(ClienteDTO clienteDTO);
        Task<ClienteDTO> UpdateCliente(int id, ClienteDTO clienteDTO);
        Task DeleteCliente(int id);
    }
}
