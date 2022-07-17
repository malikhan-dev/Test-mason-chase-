using Mc2.CrudTest.Acceptance.Framework.UnitOfWork.Contract;
using Mc2.CrudTest.Acceptance.Persistance.Ef.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Acceptance.Persistance.Ef.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AcceptanceContext _context;
        public UnitOfWork(AcceptanceContext context)
        {
            _context = context;
        }
        public Task CommitAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
