using Microsoft.AspNetCore.Mvc;
using NorthwindDataBase_MVC.Models;
using NorthwindDataBase_MVC.Models.create;
using System.Diagnostics;

namespace NorthwindDataBase_MVC.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ModifyCustomer : ControllerBase
    {
        [HttpPost()]
        public ActionResult<Customer> AddCustomer(CreateCustomerDto customerDto )
        {


            Debug.WriteLine(customerDto.Country);
            Debug.WriteLine(customerDto.City);
            Debug.WriteLine(customerDto.CustomerName);
            Debug.WriteLine(customerDto.CustomerId);
            Debug.WriteLine(customerDto.Address);
            Debug.WriteLine(customerDto.ContactName);
            Debug.WriteLine(customerDto.PostalCode);

            return Ok();
        }
    }
}
