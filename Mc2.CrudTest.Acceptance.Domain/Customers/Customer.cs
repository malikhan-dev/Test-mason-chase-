using Mc2.CrudTest.Acceptance.Framework.Models;
using System;
using System.Text.RegularExpressions;

namespace Mc2.CrudTest.Acceptance.Domain.Customers
{
    public class Customer : AggregateRoot
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public long BankAccountNumber { get; set; }

        public static Customer CreateInstance() => new Customer();

        public Customer SetName(string firstname, string lastname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            return this;
        }
        public Customer SetDateOfBirth(DateTime dob)
        {
            this.DateOfBirth = dob;
            return this;
        }

        public Customer SetContactInfo(string phonenumber, string email)
        {

            this.PhoneNumber = phonenumber;
            this.Email = email;
            return this;

        }
        public Customer SetBankAccountNumber(long bankAccountNumber)
        {
            this.BankAccountNumber = bankAccountNumber;
            return this;
        }
        public Customer Remove()
        {
            this.SoftRemove();
            return this;
        }
    }
}
