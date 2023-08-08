using MediatR;
using NorthwindDataBase_MVC.Models;

namespace NorthwindDataBase_MVC.Commands
{
    public record NewCustomerCommand(CreateCustomerDto CreateCustomerDto) : IRequest;


}