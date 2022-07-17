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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AcceptanceContext _dbContext;
        public CustomerRepository(AcceptanceContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool AddCustomer(Customer customer)
        {
            _dbContext.customers.Add(customer);
            return true;
        }


        public bool UpdateCustomer(Customer customer)
        {
            _dbContext.customers.Update(customer);
            return true;
        }

    }
}
