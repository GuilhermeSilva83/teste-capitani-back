﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Teste.Capitani.Domain.Seedwork
{
    public interface IEntity
    {
        bool IsTransient();
    }
}
