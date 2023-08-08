using AutoMapper;
using NorthwindDataBase_MVC.Models.DTOs;
using NorthwindDataBase_MVC.Models.Entity;

namespace NorthwindDataBase_MVC.Models.profileMapper;

public class CategoryMapper : Profile
{
    public CategoryMapper()
    {
        CreateMap<CategoryWithOutProductsDTO,Category>().ReverseMap();
    }
}
