using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using NorthwindDataBase_MVC.Models.DTOS;
using NorthwindDataBase_MVC.Models.Entity;
using NorthwindDataBase_MVC.Models.Repository;

namespace NorthwindDataBase_MVC.Commands
{
    public record NewCustomerCommand(NewCustomerDTO NewCustomerDTO) : IRequest<RequestsResult>;


    public class NewCustomerCommandHandler : IRequestHandler<NewCustomerCommand, RequestsResult>
    {
        public CustomerRepository _customerRepository;
        public NewCustomerCommandHandler(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<RequestsResult> Handle(NewCustomerCommand request, CancellationToken cancellationToken)
        {
            if(await _customerRepository.EmailExist(request.NewCustomerDTO.Email))
            {
                RequestsResult requstsResult = new(RequestsResult.RequestStatsEnum.EmailExist, null);
                return requstsResult;
            }
            await _customerRepository.CreateNewCustomer(request.NewCustomerDTO);
            await _customerRepository.SaveChanges();
            ReturnCustomerDTO newcustomer = await _customerRepository.FindCustomerByEmail(request.NewCustomerDTO.Email);
            return new RequestsResult(RequestsResult.RequestStatsEnum.succeed, newcustomer);

        }
    }
}