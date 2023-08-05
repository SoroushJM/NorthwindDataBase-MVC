using AutoMapper;
using NorthwindDataBase_MVC.Models.Entity;
using NorthwindDataBase_MVC.Services;

namespace NorthwindDataBase_MVC.Models.profile
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Models.Entity.Customer, customerCreationDto >().ReverseMap();
        }
    }
}
