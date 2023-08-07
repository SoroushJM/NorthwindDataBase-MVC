using AutoMapper;
using NorthwindDataBase_MVC.Models.Entity;

namespace NorthwindDataBase_MVC.Models.profileMapper
{
    public class CustomerProfile :Profile
    {
        public CustomerProfile()
        {
            CreateMap<CreateCustomerDto, Customer>();
        }
    }
}
