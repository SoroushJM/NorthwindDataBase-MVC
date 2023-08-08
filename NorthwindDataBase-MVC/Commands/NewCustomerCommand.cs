using MediatR;
using NorthwindDataBase_MVC.Models;
using NorthwindDataBase_MVC.Models.Entity;

namespace NorthwindDataBase_MVC.Commands
{
    public record NewCustomerCommand(CreateCustomerDto CreateCustomerDto) : IRequest;


}