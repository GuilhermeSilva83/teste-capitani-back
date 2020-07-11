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
            modelBuilder.Entity<Estado>().HasData(
                new Estado()
                {
                    Id = 1,
                    Nome = "São Paulo",
                },
                new Estado()
                {
                    Id = 2,
                    Nome = "Rio de Janeiro",
                },
                new Estado()
                {
                    Id = 3,
                    Nome = "Mato Grosso",
                });

            modelBuilder.Entity<Cidade>().HasData(
                  new Cidade() { Id = 1, EstadoId = 1, Nome = "São Paulo" },
                  new Cidade() { Id = 2, EstadoId = 1, Nome = "Barueri" },
                  new Cidade() { Id = 3, EstadoId = 1, Nome = "Osasco" },
                  new Cidade() { Id = 4, EstadoId = 2, Nome = "Rio de Janeiro" },
                  new Cidade() { Id = 5, EstadoId = 2, Nome = "Cabo Frio" },
                  new Cidade() { Id = 6, EstadoId = 2, Nome = "Arraial do Cabo" },
                  new Cidade() { Id = 7, EstadoId = 3, Nome = "Cuiaba" },
                  new Cidade() { Id = 8, EstadoId = 3, Nome = "Chamada dos Guimaraes" },
                  new Cidade() { Id = 9, EstadoId = 3, Nome = "Santo Antonio" }
                );
        }
    }
}
