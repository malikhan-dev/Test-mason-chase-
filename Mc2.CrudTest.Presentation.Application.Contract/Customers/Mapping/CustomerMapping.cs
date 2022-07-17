using Mc2.CrudTest.Acceptance.Domain.Customers;
using Mc2.CrudTest.Acceptance.Domain.Customers.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Presentation.Application.Contract.Customers.Mapping
{
    public static class CustomerMapping
    {
        public static CustomerDto ToDto(this Customer customer) =>
            new CustomerDto()
            {
                BankAccountNumber = customer.BankAccountNumber,
                DateOfBirth = customer.DateOfBirth,
                Email = customer.Email,
                Firstname = customer.Firstname,
                Lastname = customer.Lastname,
                PhoneNumber = customer.PhoneNumber,
                Id = customer.Id
            };
    }
}
