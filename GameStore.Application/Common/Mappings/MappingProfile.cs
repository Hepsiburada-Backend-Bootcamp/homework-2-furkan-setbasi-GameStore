using AutoMapper;
using GameStore.Application.Categories.Commands.CreateCategory;
using GameStore.Application.Categories.Queries.GetCategories;
using GameStore.Application.Categories.Queries.GetCategoryById;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Common.Mappings
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<CreateCategoryCommand, Category>();
      CreateMap<Category, GetCategoryByIdQueryResponse>();
      CreateMap<Category, GetCategoriesQueryResponse>();
    }
  }
}
