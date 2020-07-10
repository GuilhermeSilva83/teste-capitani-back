using System;
using System.Collections.Generic;
using System.Text;

using Teste.Capitani.Domain.MainContext.Aggs.CidadeAgg;
using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Domain.MainContext.Aggs.EstadoAgg
{
    public class Estado : Int32Entity
    {
        public string Nome { get; set; }

        public List<Cidade> Cidades { get; set; }
    }
}
