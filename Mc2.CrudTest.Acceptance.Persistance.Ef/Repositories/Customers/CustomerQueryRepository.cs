using Mc2.CrudTest.Acceptance.Domain.Customers;
using Mc2.CrudTest.Acceptance.Domain.Customers.Repositories;
using Mc2.CrudTest.Acceptance.Persistance.Ef.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Acceptance.Persistance.Ef.Repositories.Customers
{
    public class CustomerQueryRepository : ICustomerQueryRepository
    {
        private readonly AcceptanceContext _context;
        public CustomerQueryRepository(AcceptanceContext context)
        {
            _context = context;
        }
        public Task<Customer> GetCustomer(long id)
        {
            var customer = _context.customers.FirstOrDefaultAsync(x => x.Id == id);
            return customer;
        }
    }
}
