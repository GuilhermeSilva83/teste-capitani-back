using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Teste.Capitani.Domain.MainContext.Aggs.CidadeAgg;
using Teste.Capitani.Domain.MainContext.Aggs.EstadoAgg;
using Teste.Capitani.Domain.MainContext.Aggs.PessoaAgg;
using Teste.Capitani.WebApi.Model;

namespace Teste.Capitani.WebApi.Infra
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<Pessoa, PessoaDto>()
                .ForMember(dest =>
                    dest.EstadoId,
                    opt => opt.MapFrom(src => src.Cidade.EstadoId))
                .IgnoreAllPropertiesWithAnInaccessibleSetter()
                ;

            CreateMap<Cidade, CidadeDto>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            CreateMap<Estado, EstadoDto>().IgnoreAllPropertiesWithAnInaccessibleSetter();


        }
    }
}
