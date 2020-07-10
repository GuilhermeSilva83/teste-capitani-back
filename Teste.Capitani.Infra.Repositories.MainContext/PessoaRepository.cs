using System;
using System.Collections.Generic;
using System.Text;

using Teste.Capitani.Domain.MainContext.Aggs.PessoaAgg;
using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Infra.Repositories.MainContext
{
    public class PessoaRepository : Int32Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(IUnitOfWork u) : base(u)
        {

        }
    }
}
