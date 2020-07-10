using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Teste.Capitani.Domain.MainContext.Aggs.PessoaAgg;
using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Infra.Repositories.MainContext
{
    public class PessoaRepository : Int32Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(IUnitOfWork u) : base(u)
        {

        }

        public override async Task<Pessoa> GetById(int id)
        {
            return await GetSet()
                    .Include(w => w.Cidade)
                    .FirstOrDefaultAsync(w => w.Id == id);
        }
    }
}
