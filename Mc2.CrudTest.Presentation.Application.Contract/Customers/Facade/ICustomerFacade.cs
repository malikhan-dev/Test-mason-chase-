using Mc2.CrudTest.Presentation.Application.Contract.Customers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Presentation.Application.Contract.Customers.Facade
{
    public interface ICustomerFacade
    {
        Task<bool> CreateCustomer(CreateCustomerCommand command);
        Task<bool> UpdateCustomer(UpdateCustomerCommand command);
        Task<bool> RemoveCustomer(RemoveCustomerCommand command);
    }
}
