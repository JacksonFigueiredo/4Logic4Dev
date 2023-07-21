using _4Logic4Devs.Domain.Models;
using _4Logic4Devs.Repository.Interfaces;
using _4Logic4Devs.Repository.Services;
using _4Logic4Devs.Services.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Logic4Devs.Services.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _cliRepo;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository cliRepo, IMapper mapper)
        {
            _cliRepo = cliRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClienteDTO>> GetClientes()
        {
            var clientes = await _cliRepo.GetClientes();
            return _mapper.Map<IEnumerable<ClienteDTO>>(clientes);
        }

        public async Task<ClienteDTO> GetCliente(int id)
        {
            var cliente = await _cliRepo.GetCliente(id);
            return _mapper.Map<ClienteDTO>(cliente);
        }

        public async Task<ClienteDTO> CreateCliente(ClienteDTO clienteDTO)
        {
            var existingCliente = await _cliRepo.GetByCnpjAsync(clienteDTO.CNPJ);

            if (existingCliente != null)
            {
                throw new Exception("Um cliente com esse CNPJ já existe.");
            }

            var cliente = _mapper.Map<Cliente>(clienteDTO);
            await _cliRepo.CreateCliente(cliente);
            return _mapper.Map<ClienteDTO>(cliente);
        }

        public async Task<ClienteDTO> UpdateCliente(int id, ClienteDTO clienteDTO)
        {
            var cliente = _mapper.Map<Cliente>(clienteDTO);
            await _cliRepo.UpdateCliente(id, cliente);
            return _mapper.Map<ClienteDTO>(cliente);
        }

        public async Task DeleteCliente(int id)
        {
            await _cliRepo.DeleteCliente(id);
        }
    }
}
