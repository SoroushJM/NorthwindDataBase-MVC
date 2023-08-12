using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NorthwindDataBase_MVC.Commands;
using NorthwindDataBase_MVC.Models.DTOS;
using NorthwindDataBase_MVC.Models.Entity;
using NorthwindDataBase_MVC.Models.Services;
using NorthwindDataBase_MVC.Queries.Customer;
using NuGet.Protocol;

namespace NorthwindDataBase_MVC.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class CustomersController : Controller
    {
        public IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerWith(int id)
        {
            return Ok(await _mediator.Send(new GetCustomerQueryById(id)));
        }

    }
}
