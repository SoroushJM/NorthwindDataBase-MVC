using MediatR;
using NorthwindDataBase_MVC.Models.DTOS;

namespace NorthwindDataBase_MVC.Queries.Customer;

public record GetCustomerQueryById(int Id) : IRequest<ReturnCustomerDTO>;
