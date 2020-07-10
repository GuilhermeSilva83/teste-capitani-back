using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.WebApi.Controllers
{
    public class Int32CrudController<TRepository, TEntity> : ControllerBase
        where TRepository : class, IRepository<TEntity, int>
        where TEntity : class

    {
        protected IUnitOfWork unitOfWork = null;
        protected TRepository repository = null;

        public Int32CrudController(IUnitOfWork uow, TRepository rep)
        {
            this.unitOfWork = uow;
            this.repository = rep;
        }


        [HttpGet]
        public async Task<IEnumerable<TEntity>> Get()
        {
            return await repository.List();
        }

        [HttpGet("{id}")]
        public async Task<TEntity> Get(int id)
        {
            return await this.repository.GetById(id);
        }

        [HttpPost]
        public OperationResult Post([FromBody] TEntity value)
        {
            repository.Save(value);
            unitOfWork.Commit();
            return OperationResult.Ok(value);

        }

        [HttpPut("{id}")]
        public OperationResult Put([FromBody] TEntity value)
        {
            repository.Save(value);
            unitOfWork.Commit();

            return OperationResult.Ok(value);
        }

        [HttpDelete("{id}")]
        public OperationResult Delete(int id)
        {
            repository.DeleteById(id);
            unitOfWork.Commit();
            return OperationResult.Ok();
        }
    }
}
