using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

using Teste.Capitani.Domain.MainContext.Aggs.CidadeAgg;
using Teste.Capitani.Domain.MainContext.Aggs.EstadoAgg;
using Teste.Capitani.Domain.MainContext.Aggs.PessoaAgg;
using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Infra.Repositories.MainContext
{
    public class MainUnitOfWork : DbContext, IUnitOfWork
    {
        public readonly Guid Guid = Guid.NewGuid();
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }

        public void Commit()
        {
            this.SaveChanges();
        }



        public MainUnitOfWork(DbContextOptions<MainUnitOfWork> options) : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
