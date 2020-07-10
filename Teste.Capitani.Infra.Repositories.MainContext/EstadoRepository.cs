using System;
using System.Collections.Generic;
using System.Text;

using Teste.Capitani.Domain.MainContext.Aggs.EstadoAgg;
using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Infra.Repositories.MainContext
{
    public class EstadoRepository : Int32Repository<Estado>, IEstadoRepository
    {
        public EstadoRepository(IUnitOfWork u) : base(u)
        {

        }
    }
}
