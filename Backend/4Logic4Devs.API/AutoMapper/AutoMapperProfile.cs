using _4Logic4Devs.Domain.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _4Logic4Devs.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<Avaliacao, AvaliacaoDTO>();
          

            CreateMap<ClienteDTO, Cliente>();
            CreateMap<AvaliacaoDTO, Avaliacao>();




        }

    }
}

