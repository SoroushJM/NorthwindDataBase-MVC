using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NorthwindDataBase_MVC.Data;
using NorthwindDataBase_MVC.Models.DTOS;

namespace NorthwindDataBase_MVC.Queries.Customer;

public record GetCustomerQueryById(int Id) : IRequest<ReturnCustomerDTO>;

public class GetCustomerQueryByIdHandler : IRequestHandler<GetCustomerQueryById, ReturnCustomerDTO>
{
    private readonly FileContext _context;
    private readonly IMapper _mapper;
    public GetCustomerQueryByIdHandler(FileContext context, IMapper mapper)
    {
        _context = context ?? throw new NullReferenceException();
        _mapper = mapper ?? throw new NullReferenceException();
    }

    public async Task<ReturnCustomerDTO> Handle(GetCustomerQueryById request, CancellationToken cancellationToken)
    {
        var customer = await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == request.Id, cancellationToken: cancellationToken);
        ReturnCustomerDTO customerDto = _mapper.Map<ReturnCustomerDTO>(customer);
        return customerDto;

    }
}
