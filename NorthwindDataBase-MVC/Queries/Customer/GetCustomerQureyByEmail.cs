using AutoMapper;
using MediatR;
using NorthwindDataBase_MVC.Models.DTOS;
using NorthwindDataBase_MVC.Models.Repository;
using NuGet.Protocol.Core.Types;

namespace NorthwindDataBase_MVC.Queries.Customer
{
    public class GetCustomerQureyByEmail : IRequest<ReturnCustomerDTO>
    {
        public IMapper _mapper;
        public string _email;
        public CustomerRepository _customerRepository { get; set; }
        public GetCustomerQureyByEmail(string email ,IMapper mapper =null! ,CustomerRepository customerRepository = null!)
        {
            _mapper = mapper ?? throw new NullReferenceException();
            _email = email ?? throw new NullReferenceException();
            _customerRepository = customerRepository ?? throw new NullReferenceException();
        }
    }

    public class GetCustomerHandler : IRequestHandler<GetCustomerQureyByEmail, ReturnCustomerDTO>
    {
        public async Task<ReturnCustomerDTO> Handle(GetCustomerQureyByEmail request, CancellationToken cancellationToken)
        {
            ReturnCustomerDTO customer = await request._customerRepository.FindCustomerByEmail(request._email);
            return customer;
        }
    }
}
