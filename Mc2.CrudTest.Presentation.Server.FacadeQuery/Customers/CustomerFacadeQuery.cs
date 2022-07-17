using Mc2.CrudTest.Acceptance.Domain.Customers.Dtos;
using Mc2.CrudTest.Acceptance.Domain.Customers.Repositories;
using Mc2.CrudTest.Presentation.Application.Contract.Customers.FacadeQuery;
using Mc2.CrudTest.Presentation.Application.Contract.Customers.Mapping;
using Mc2.CrudTest.Presentation.Application.Contract.Customers.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Presentation.Server.FacadeQuery.Customers
{
    public class CustomerFacadeQuery : ICustomerFacadeQuery
    {
        private readonly ICustomerQueryRepository _customerQueryRepository;
        public CustomerFacadeQuery(ICustomerQueryRepository customerQueryRepository)
        {
            _customerQueryRepository = customerQueryRepository;
        }
        public async Task<CustomerDto> GetCustomer(GetCustomerQuery query)
        {
            var res = await _customerQueryRepository.GetCustomer(query.CustomerId);
            return res.ToDto();
        }
    }
}
