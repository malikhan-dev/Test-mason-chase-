using Mc2.CrudTest.Acceptance.Domain.Customers.Dtos;
using Mc2.CrudTest.Presentation.Application.Contract.Customers.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Presentation.Application.Contract.Customers.FacadeQuery
{
    public interface ICustomerFacadeQuery
    {
        Task<CustomerDto> GetCustomer(GetCustomerQuery query);
    }
}
