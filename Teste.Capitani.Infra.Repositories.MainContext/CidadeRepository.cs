using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Teste.Capitani.Domain.MainContext.Aggs.CidadeAgg;
using Teste.Capitani.Domain.MainContext.Aggs.EstadoAgg;
using Teste.Capitani.Domain.MainContext.Aggs.PessoaAgg;
using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Infra.Repositories.MainContext
{
    public class CidadeRepository : Int32Repository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(IUnitOfWork u) : base(u)
        {

        }

        public async Task<List<Cidade>> ListarPorEstado(int estadoId)
        {
            return await GetSet().Where(w => w.EstadoId == estadoId).ToListAsync();
        }
    }
}
