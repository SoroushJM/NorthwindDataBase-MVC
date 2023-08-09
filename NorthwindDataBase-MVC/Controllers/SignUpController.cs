using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using NorthwindDataBase_MVC.Models.DTOS;

namespace NorthwindDataBase_MVC.Controllers
{
    [Route("[Controller]")]
    public class SignUpController : ControllerBase
    {
        public IMediator _mediator;
        public SignUpController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public IActionResult NewUser(NewCustomerDTO newCustomerDTO)
        {
            _mediator.Send(newCustomerDTO);
            throw new NotImplementedException();
        }
    }
}
