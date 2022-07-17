using Mc2.CrudTest.Presentation.Application.Contract.Customers.Commands;
using Mc2.CrudTest.Presentation.Application.Contract.Customers.Facade;
using Mc2.CrudTest.Presentation.Application.Contract.Customers.FacadeQuery;
using Mc2.CrudTest.Presentation.Application.Contract.Customers.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Presentation.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerFacade _customerFacade;
        private readonly ICustomerFacadeQuery _customerFacadeQuery;
        public CustomerController(ICustomerFacade customerFacade, ICustomerFacadeQuery customerFacadeQuery)
        {
            _customerFacade = customerFacade;
            _customerFacadeQuery = customerFacadeQuery;
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateCustomerCommand command)
        {
            await _customerFacade.CreateCustomer(command);
            return Ok();
        }
        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCustomerCommand command)
        {
            await _customerFacade.UpdateCustomer(command);
            return Ok();
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Update([FromQuery] RemoveCustomerCommand command)
        {
            await _customerFacade.RemoveCustomer(command);
            return Ok();
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] GetCustomerQuery command)
        {
            var res = await _customerFacadeQuery.GetCustomer(command);
            return Ok(res);
        }
    }
}
