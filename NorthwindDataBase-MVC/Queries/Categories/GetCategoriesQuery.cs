using MediatR;
using NorthwindDataBase_MVC.Models.DTOs;

namespace NorthwindDataBase_MVC.Queries.Categories
{
    public record GetAllCategoriesQuerys(): IRequest<List<CategoryWithOutProductsDTO>>;
}
