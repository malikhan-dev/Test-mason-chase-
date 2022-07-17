using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Acceptance.Framework.UnitOfWork.Contract
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
