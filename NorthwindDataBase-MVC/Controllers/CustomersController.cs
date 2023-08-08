using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NorthwindDataBase_MVC.Commands;
using NorthwindDataBase_MVC.Models;
using NorthwindDataBase_MVC.Models.Entity;
using NorthwindDataBase_MVC.Models.Services;
using NorthwindDataBase_MVC.Queries.Customer;

namespace NorthwindDataBase_MVC.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CustomersController : Controller
    {
        public IMapper _mapper;
        public CustomerRepository _customerRepository;
        public IMediator _mediator;

        public CustomersController(CustomerRepository customerRepository,
            IMapper mapper,
            IMediator mediator)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _mediator = mediator;
        }
        [HttpGet()]
        public IActionResult Index()
        {
            return View(_customerRepository);
        }


        [HttpGet("salam/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }
        [HttpPost]
        public IActionResult PostCustomer(CreateCustomerDto customerDto)
        {
            Customer customer = _mapper.Map<Customer>(customerDto);
            _customerRepository.CreateCustomer(customer);
            _customerRepository.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCustomer(int id, CreateCustomerDto customerDto)
        {
            Customer customer = _customerRepository.GetCustomerById(id);
            if (customer is null)
            {
                return NotFound();
            }
            _mapper.Map(customerDto, customer);
            _customerRepository.SaveChanges();
            return Ok();
        }

        [HttpGet("mediator/{id}")]
        public IActionResult GetCustomerWithMidator(int id)
        {
            return Ok(_mediator.Send(new GetCustomerQuery(id)).Result);
        }

        [HttpPost("mediator")]
        public IActionResult PostCustomerWithMidator(CreateCustomerDto createCustomerDto)
        {
            var command = new NewCustomerCommand(createCustomerDto);
            _mediator.Send(command);
            return Ok();
        }
    }
}
