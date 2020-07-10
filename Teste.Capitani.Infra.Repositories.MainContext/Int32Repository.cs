using System;

using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Infra.Repositories.MainContext
{
    public class Int32Repository<TEntity> : Repository<TEntity>
           where TEntity : class, IEntity
    {
    }
}
