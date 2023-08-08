﻿using MediatR;
using NorthwindDataBase_MVC.Data;

namespace NorthwindDataBase_MVC.Queries.Customer
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, Models.Entity.Customer>
    {
        private readonly FileContext _context;

        public GetCustomerQueryHandler(FileContext context)
        {
            _context = context;
        }

        public Task<Models.Entity.Customer> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_context.Customers.FirstOrDefault(c => c.CustomerId == request.Id));
        }
    }
}