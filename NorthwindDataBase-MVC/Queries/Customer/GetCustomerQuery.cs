using MediatR;

namespace NorthwindDataBase_MVC.Queries.Customer;

public record GetCustomerQuery(int Id) : IRequest<Models.Entity.Customer>;
