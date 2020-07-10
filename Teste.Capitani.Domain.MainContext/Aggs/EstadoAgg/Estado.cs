using System;
using System.Collections.Generic;
using System.Text;

using Teste.Capitani.Domain.MainContext.Aggs.CidadeAgg;

namespace Teste.Capitani.Domain.MainContext.Aggs.EstadoAgg
{
    public class Estado
    {
        public string Nome { get; set; }

        public List<Cidade> Cidades { get; set; }
    }
}
