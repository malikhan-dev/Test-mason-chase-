using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Acceptance.Domain.Customers.Repositories
{
    public interface ICustomerQueryRepository
    {
        Task<Customer> GetCustomer(long id);
    }
}
