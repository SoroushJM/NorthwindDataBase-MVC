using AutoMapper;
using MediatR;
using NorthwindDataBase_MVC.Data;
using NorthwindDataBase_MVC.Models;
using NorthwindDataBase_MVC.Models.Entity;
using SQLitePCL;

namespace NorthwindDataBase_MVC.Commands
{
    public class NewCustomerCommandHandler : IRequestHandler<NewCustomerCommand>
    {
        public IMapper _mapper { get; set; }
        public FileContext _context { get; set; }
        public NewCustomerCommandHandler(IMapper mapper ,FileContext context) 
        { 
            _mapper = mapper;
            _context = context;
        }

        public async Task Handle(NewCustomerCommand request, CancellationToken cancellationToken)
        {
            Customer customer = _mapper.Map<Customer>(request.CreateCustomerDto);
            _context.Add(customer);
            await _context.SaveChangesAsync();
        }
    }
}
