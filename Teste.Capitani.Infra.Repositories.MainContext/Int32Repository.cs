using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Infra.Repositories.MainContext
{
    public class Int32Repository<TEntity> : IInt32Repository<TEntity>
       where TEntity : class, IEntity<int>, new()
    {
        private readonly MainUnitOfWork ct;
        public Int32Repository(IUnitOfWork ct)
        {
            this.ct = ct as MainUnitOfWork;
        }

        public virtual void DeleteById(int id)
        {
            var set = GetSet();
            //  var e = await set.AsNoTracking().FirstOrDefaultAsync(w => w.Id == id); // await this.GetById(id);
            var e = new TEntity();
            e.Id = id;
            set.Remove(e);
        }

        public virtual void Save(TEntity entity)
        {
            if (entity.IsTransient())
            {
                GetSet().Add(entity);
            }
            else
            {
                //GetSet().Attach(entity);
                GetSet().Update(entity);

            }
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await GetSet().FirstOrDefaultAsync(f => f.Id == id);
        }

        public virtual async Task<List<TEntity>> List()
        {
            return await GetSet().ToListAsync();
        }

        protected virtual DbSet<TEntity> GetSet()
        {
            return ct.Set<TEntity>();
        }
    }
}
