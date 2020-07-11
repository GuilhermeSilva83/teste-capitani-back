using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

using Teste.Capitani.Domain.MainContext.Aggs.CidadeAgg;
using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Domain.MainContext.Aggs.PessoaAgg
{
    public class Pessoa : Int32Entity
    {
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(11)]
        public string Cpf { get; set; }

        [MaxLength(8)]
        public string Cep { get; set; }

        public DateTime DataNascimento { get; set; }

        public int CidadeId { get; set; }

        [ForeignKey(nameof(CidadeId))]
        public Cidade Cidade { get; set; }



    }
}
