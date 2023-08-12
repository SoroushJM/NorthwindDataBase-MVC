using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using NorthwindDataBase_MVC.Commands;
using NorthwindDataBase_MVC.Models.DTOS;
using NuGet.Protocol;

namespace NorthwindDataBase_MVC.Controllers
{
    [Route("API/[Controller]")]
    public class SignUpController : ControllerBase
    {
        public IMediator _mediator;
        public SignUpController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost()]
        public async Task<ActionResult> PostCustomer([FromBody] NewCustomerDTO createCustomerDto)
        {
            RequestsResult customerDTO = await _mediator.Send(new NewCustomerCommand(createCustomerDto));
            return Ok(customerDTO.ToJson());
        }
    }
}
