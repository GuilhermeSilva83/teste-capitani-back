using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using Teste.Capitani.Domain.MainContext.Aggs.PessoaAgg;
using Teste.Capitani.Domain.Seedwork;
using Teste.Capitani.WebApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Teste.Capitani.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : Int32CrudController<IPessoaRepository, Pessoa>
    {
        public PessoaController(IUnitOfWork uow, IPessoaRepository rep, IMapper mapper) : base(uow, rep, mapper)
        {
        }


        [NonAction]
        public override Task<Pessoa> Get(int id)
        {
            return base.Get(id);
        }

        [NonAction]
        public override Task<IEnumerable<Pessoa>> List()
        {
            return base.List();
        }

        [HttpGet]
        public async Task<IEnumerable<PessoaDto>> ListDto()
        {
            return mapper.Map<List<PessoaDto>>(await List());
        }


        [HttpGet("{id}")]
        public virtual async Task<PessoaDto> GetById(int id)
        {
            var e = await this.repository.GetById(id);
            return mapper.Map<PessoaDto>(e);
        }

    }
}
