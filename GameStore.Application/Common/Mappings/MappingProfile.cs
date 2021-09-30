﻿using AutoMapper;
using GameStore.Application.Categories.Commands.CreateCategory;
using GameStore.Application.Categories.Queries.GetCategories;
using GameStore.Application.Categories.Queries.GetCategoryById;
using GameStore.Application.Games.Commands.CreateGame;
using GameStore.Application.Games.Queries;
using GameStore.Application.Games.Queries.GetGameById;
using GameStore.Application.Games.Queries.GetGames;
using GameStore.Application.Games.Queries.SharedSubFields;
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
      CreateMap<CreateGameCommand, Game>();

      CreateMap<Category, GetCategoryByIdQueryResponse>();
      CreateMap<Category, GetCategoriesQueryResponse>();

      CreateMap<Game, GetGamesQueryResponse>();
      CreateMap<Game, GetGameByIdQueryResponse>();

      CreateMap<Category, CategoryDto>();
      CreateMap<Developer, DeveloperDto>();
    }
  }
}
