using System;

namespace Mc2.CrudTest.Presentation.Application.Contract.Customers.Commands
{
    public class UpdateCustomerCommand
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public long BankAccountNumber { get; set; }
    }
}
