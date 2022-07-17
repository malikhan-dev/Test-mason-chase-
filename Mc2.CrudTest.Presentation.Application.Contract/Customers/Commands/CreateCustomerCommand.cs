using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Presentation.Application.Contract.Customers.Commands
{
    public class CreateCustomerCommand
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }

        //[DisplayName("Phone number")]
        //[Required(ErrorMessage = "Phone number is required")]
        //[RegularExpression(@"09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}", ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }
        //[DisplayName("email")]
        //[Required(ErrorMessage = "email is required")]
        //[RegularExpression(@"([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6})*$")]
        public string Email { get; set; }
        public long BankAccountNumber { get; set; }
    }
}
