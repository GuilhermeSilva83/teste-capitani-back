using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Teste.Capitani.Domain.MainContext.Aggs.EstadoAgg;
using Teste.Capitani.Domain.Seedwork;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Teste.Capitani.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : Int32CrudController<IEstadoRepository, Estado>
    {
        IUnitOfWork uow = null;
        IEstadoRepository rep = null;

        public EstadoController(IUnitOfWork uow, IEstadoRepository rep) : base(uow, rep)
        {
            this.uow = uow;
            this.rep = rep;
        }


    }
}
