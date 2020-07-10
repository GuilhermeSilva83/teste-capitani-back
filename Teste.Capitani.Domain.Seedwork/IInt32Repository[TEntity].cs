using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Capitani.Domain.Seedwork
{
    public interface IInt32Repository<TEntity> : IRepository<TEntity, int>
        where TEntity : class
    {

    }
}
