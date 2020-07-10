using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Infra.Repositories.MainContext
{
    public class Int32Repository<TEntity> : IInt32Repository<TEntity>
       where TEntity : class, IEntity<int>
    {
        private readonly DbContext ct;
        public Int32Repository(DbContext ct)
        {
            this.ct = ct;
        }

        public async Task DeleteById(int id)
        {
            var set = GetSet();
            set.Remove(await this.GetById(id));
        }

        public void Save(TEntity entity)
        {
            if (entity.IsTransient())
            {
                GetSet().Add(entity);
            }
            else
            {
                GetSet().Attach(entity);
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            return await GetSet().FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<List<TEntity>> List()
        {
            return await GetSet().ToListAsync();
        }

        protected DbSet<TEntity> GetSet()
        {
            return ct.Set<TEntity>();
        }
    }
}
