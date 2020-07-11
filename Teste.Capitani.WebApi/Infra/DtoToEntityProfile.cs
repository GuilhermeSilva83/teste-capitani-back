using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Teste.Capitani.Domain.MainContext.Aggs.PessoaAgg;
using Teste.Capitani.WebApi.Model;

namespace Teste.Capitani.WebApi.Infra
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<PessoaDto, Pessoa>()
                .IgnoreAllPropertiesWithAnInaccessibleSetter();

        }
    }
}
