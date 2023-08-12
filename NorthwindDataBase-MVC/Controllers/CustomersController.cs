using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NorthwindDataBase_MVC.Commands;
using NorthwindDataBase_MVC.Models.DTOS;
using NorthwindDataBase_MVC.Models.Entity;
using NorthwindDataBase_MVC.Models.Services;
using NorthwindDataBase_MVC.Queries.Customer;

namespace NorthwindDataBase_MVC.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
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
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerWith(int id)
        {
            return Ok(await _mediator.Send(new GetCustomerQueryById(id)));
        }

        [HttpPost()]
        public async Task<IActionResult> PostCustomer(NewCustomerDTO createCustomerDto)
        {
            //var command = new NewCustomerCommand(createCustomerDto);
            //await _mediator.Send(command);
            //return Ok();
            throw new NotImplementedException();
        }
    }
}
