using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NorthwindDataBase_MVC.Data;
using NorthwindDataBase_MVC.Models.DTOs;
using NorthwindDataBase_MVC.Models.Entity;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace NorthwindDataBase_MVC.Queries.Categories
{
    public class GetCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuerys, List<CategoryWithOutProductsDTO>>
    {
        FileContext _Context;
        IMapper _Mapper;
        public GetCategoriesQueryHandler(FileContext fileContext , IMapper mapper)
        {
            _Context = fileContext;
            _Mapper = mapper;
        }

        public Task<List<CategoryWithOutProductsDTO>> Handle(GetAllCategoriesQuerys request, CancellationToken cancellationToken)
        {
            var listOfAllCategory = _Context.Categories.ToList();
            var ListOfAllCategoryWithOutProducts = new List<CategoryWithOutProductsDTO>();
            foreach (var item in listOfAllCategory)
            {
                ListOfAllCategoryWithOutProducts.Add(_Mapper.Map<CategoryWithOutProductsDTO>(item));
            }
            return Task.FromResult(ListOfAllCategoryWithOutProducts);
        }
    }
}
