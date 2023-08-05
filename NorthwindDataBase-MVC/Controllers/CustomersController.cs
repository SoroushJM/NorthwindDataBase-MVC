using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NorthwindDataBase_MVC.Models.create;
using NorthwindDataBase_MVC.Services;
using NuGet.Protocol;

namespace NorthwindDataBase_MVC.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CustomersController : Controller
    {
        public IMapper _mapper;
        public CustomerRepository _customerRepository;
        public CustomersController(CustomerRepository customerRepository, IMapper mapper)
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
        public IActionResult GetCustomerById(int id, bool returnWithUI = true)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (returnWithUI)
                return View(customer);
            else
            {
                if (customer == null)
                {
                    return NotFound();
                }
                return Ok(customer);
            }
        }
        [HttpPost("CreateCustomer")]
        public ActionResult<customerCreationDto> CreateNewCustomer(customerCreationDto customerdto)
        {
            var customer = _mapper.Map<Models.Entity.Customer>(customerdto);
            //_customerRepository.AddCustomer(customer);
            _customerRepository.SaveChanges();
            return Ok();
        }
    }
}
