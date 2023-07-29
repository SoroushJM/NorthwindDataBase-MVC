using Microsoft.AspNetCore.Mvc;
using NorthwindDataBase_MVC.Models;
using NuGet.Protocol;

namespace NorthwindDataBase_MVC.Controllers
{
    public class GetCustomers : Controller
    {
        CustomerRepository _customerRepository;
        public GetCustomers(CustomerRepository customerRepository) {
            _customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            return View(_customerRepository);
        }


        [HttpGet("[Controller]/{id}")]
        public IActionResult GetCustomerById(int id, bool json = true)
        {
            var customerWithId = _customerRepository.GetCustomer(id);
            if(json && customerWithId is not null)
            {
                return Ok(_customerRepository.GetCustomer(id));
            }
            if(json && customerWithId is null)
            {
                return NotFound();
            }
            if(!json  && customerWithId is null)
            {
                return BadRequest();
            }
            return NotFound();
        }
    }
}
