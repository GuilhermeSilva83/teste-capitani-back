using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Capitani.Domain.Seedwork
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
