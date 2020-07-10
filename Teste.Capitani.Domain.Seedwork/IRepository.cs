using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Teste.Capitani.Domain.Seedwork
{
    public interface IRepository<TEntity, TId>
        where TEntity : class
    {
        void Save(TEntity entity);

        Task<List<TEntity>> List();

        Task DeleteById(TId id);
        Task<TEntity> GetById(TId id);
    }
}
