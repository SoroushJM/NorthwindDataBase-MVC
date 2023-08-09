using MediatR;
using NorthwindDataBase_MVC.Models.DTOS;
using NorthwindDataBase_MVC.Models.Entity;
using NorthwindDataBase_MVC.Models.Repository;

namespace NorthwindDataBase_MVC.Commands
{
    public class NewCustomerCommand : IRequest<(ReturnCustomerDTO,CreateCustomerStats)>
    {
        public CustomerRepository _customerRepository;
        public NewCustomerDTO _newCustomerDTO;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newCustomerDTO">pass the new Customer object that you get from controller</param>
        /// <param name="customerRepository">dependency injection will give this item do not pass this object</param>
        /// <exception cref="NullReferenceException"></exception>
        public NewCustomerCommand(NewCustomerDTO newCustomerDTO ,CustomerRepository customerRepository =null!)
        {
            _newCustomerDTO = newCustomerDTO ?? throw new NullReferenceException();
            _customerRepository = customerRepository ?? throw new NullReferenceException();
        }
    }
    public class NewCustomerCommandHandler : IRequestHandler<NewCustomerCommand, (ReturnCustomerDTO, CreateCustomerStats)>
    {

        async Task<(ReturnCustomerDTO, CreateCustomerStats)> IRequestHandler<NewCustomerCommand, (ReturnCustomerDTO, CreateCustomerStats)>.Handle(NewCustomerCommand request, CancellationToken cancellationToken)
        {
            bool isExist = await request._customerRepository.EmailExist(request._newCustomerDTO.Email);
            if (isExist)
            {
                CreateCustomerStats createCustomerStats= new CreateCustomerStats();
                createCustomerStats.EmailExists = true;
                return Task.FromResult((request., createCustomerStats));
            }
            throw new NotImplementedException();
        }
    }
}