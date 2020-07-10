using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Domain.MainContext.Aggs.CidadeAgg
{
    public interface ICidadeRepository : IRepository<Cidade, int>
    {
        Task<List<Cidade>> ListarPorEstado(int estadoId);
    }
}
