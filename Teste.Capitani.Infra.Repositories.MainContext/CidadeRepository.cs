using System;
using System.Collections.Generic;
using System.Text;

using Teste.Capitani.Domain.MainContext.Aggs.CidadeAgg;
using Teste.Capitani.Domain.MainContext.Aggs.PessoaAgg;
using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Infra.Repositories.MainContext
{
    public class CidadeRepository : Int32Repository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(IUnitOfWork u) : base(u)
        {

        }
    }
}
