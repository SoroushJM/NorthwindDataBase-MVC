using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NorthwindDataBase_MVC.Models.Entity;
using NorthwindDataBase_MVC.Models.Services;
using NuGet.Protocol;

namespace NorthwindDataBase_MVC.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CustomersController : Controller
    {
        public IMapper _mapper;
        public CustomerRepository _customerRepository;
        public CustomersController(CustomerRepository customerRepository,
            IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        [HttpGet()]
        public IActionResult Index()
        {
            return View(_customerRepository);
        }


        [HttpGet("GetCustomerById/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
                if (customer == null)
                {
                    return NotFound();
                }
                return Ok(customer);
        }
        [HttpPost("PostCustomer")]
        public IActionResult PostCustomer(CreateCustomerDto customerDto)
        {
            Customer customer = _mapper.Map<Customer>(customerDto);
            _customerRepository.CreateCustomer(customer);
            _customerRepository.SaveChanges();
            return Ok();
        }
    }
}
