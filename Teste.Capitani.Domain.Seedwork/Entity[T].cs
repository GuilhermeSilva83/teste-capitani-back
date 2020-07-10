using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Teste.Capitani.Domain.Seedwork
{
    public abstract class Entity<TId> : IEntity<TId>
    {
        public abstract TId Id { get; set; }
        public abstract bool IsTransient();
    }
}
