using System;
using System.Collections.Generic;
using System.Text;

using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Domain.MainContext.Aggs.PessoaAgg
{
    public class Pessoa : Int32Entity
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public int CidadeId { get; set; }

        public string EstadoId { get; set; }



    }
}
