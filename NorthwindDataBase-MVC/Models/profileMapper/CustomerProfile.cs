using AutoMapper;
using NorthwindDataBase_MVC.Models.Entity;
using NorthwindDataBase_MVC.Models.Services;

namespace NorthwindDataBase_MVC.Models.profileMapper
{
    public class CustomerProfile :Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CreateCustomerDto>().ReverseMap();
        }
    }
}
