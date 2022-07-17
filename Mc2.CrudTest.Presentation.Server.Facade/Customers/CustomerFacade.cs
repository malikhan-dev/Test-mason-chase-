using Mc2.CrudTest.Acceptance.Domain.Customers;
using Mc2.CrudTest.Acceptance.Domain.Customers.Repositories;
using Mc2.CrudTest.Acceptance.Framework.UnitOfWork.Contract;
using Mc2.CrudTest.Presentation.Application.Contract.Customers.Commands;
using Mc2.CrudTest.Presentation.Application.Contract.Customers.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Presentation.Server.Facade.Customers
{
    public class CustomerFacade : ICustomerFacade
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerQueryRepository _customerQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CustomerFacade(ICustomerRepository customerRepository, IUnitOfWork unitOfWork, ICustomerQueryRepository customerQueryRepository)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
            _customerQueryRepository = customerQueryRepository;
        }
        public async Task<bool> CreateCustomer(CreateCustomerCommand command)
        {
            var model = Customer.CreateInstance().SetBankAccountNumber(command.BankAccountNumber)
                                .SetContactInfo(command.PhoneNumber, command.Email)
                                .SetDateOfBirth(command.DateOfBirth)
                                .SetName(command.Firstname, command.Lastname);

            _customerRepository.AddCustomer(model);

            await _unitOfWork.CommitAsync();

            return true;
        }
        public async Task<bool> UpdateCustomer(UpdateCustomerCommand command)
        {
            var model = await _customerQueryRepository.GetCustomer(command.Id);

            model.SetBankAccountNumber(command.BankAccountNumber)
                                .SetContactInfo(command.PhoneNumber, command.Email)
                                .SetDateOfBirth(command.DateOfBirth)
                                .SetName(command.Firstname, command.Lastname);

            _customerRepository.UpdateCustomer(model);

            await _unitOfWork.CommitAsync();

            return true;
        }

        public async Task<bool> RemoveCustomer(RemoveCustomerCommand command)
        {
            var model = await _customerQueryRepository.GetCustomer(command.Id);

            model.Remove();

            _customerRepository.UpdateCustomer(model);

            await _unitOfWork.CommitAsync();

            return true;
        }
    }
}
