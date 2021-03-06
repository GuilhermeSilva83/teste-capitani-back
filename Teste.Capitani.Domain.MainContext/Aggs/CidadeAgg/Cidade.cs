﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

using Teste.Capitani.Domain.MainContext.Aggs.EstadoAgg;
using Teste.Capitani.Domain.Seedwork;

namespace Teste.Capitani.Domain.MainContext.Aggs.CidadeAgg
{
    public class Cidade : Int32Entity
    {
        public string Nome { get; set; }

        public int EstadoId { get; set; }

        [ForeignKey(nameof(EstadoId))]
        public Estado Estado { get; set; }
    }
}
