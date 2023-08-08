using MediatR;
using Microsoft.AspNetCore.Mvc;
using NorthwindDataBase_MVC.Queries.Categories;

namespace NorthwindDataBase_MVC.Controllers
{
    [Route("Api/[Controller]")]
    public class CategorieController : ControllerBase
    {
        public IMediator _mediator;
        public CategorieController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllCategories()
        {
            var returnResult = _mediator.Send(new GetAllCategoriesQuerys()).Result;
            return Ok(returnResult);
        }
    }
}
