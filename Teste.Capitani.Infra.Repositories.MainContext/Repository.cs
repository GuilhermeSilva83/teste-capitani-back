using System;
using System.Collections.Generic;
using System.Text;

using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Infra.Repositories.MainContext
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
    }
}
