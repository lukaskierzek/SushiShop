﻿using AutoMapper;
using SushiShopAngular.Server.Enums;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO;
using SushiShopAngular.Server.Models.ModelsDTO.Ingredient;
using SushiShopAngular.Server.Models.ModelsDTO.Sushi;

namespace SushiShopAngular.Server.Mapping
{
    public class SushiShopMapping : Profile
    {
        public SushiShopMapping()
        {
            CreateMap<Sushi, SushiDTO>()
                .ForMember(sushidto => sushidto.Description, c => c.MapFrom(sushi => sushi.Description.Description))
                .ForMember(sushidto => sushidto.MainCategory, c => c.MapFrom(sushi => sushi.MainCategory.Name))
                //.ForMember(sushidto => sushidto.Ingrediets, c => c.MapFrom(sushi => sushi.sushiIngredients.Select(y => y.Ingredient).ToList()))
                .ForMember(sushidto => sushidto.ingredients, c => c.MapFrom(sushi => sushi.sushiIngredients))
                .ForMember(sushidto => sushidto.SubCategories, c => c.MapFrom(sushi => sushi.sushiSubCategories.Select(ssc => ssc.SubCategory).ToList()));

            CreateMap<SubCategory, SubCategoryDTO>();

            CreateMap<SushiIngredient, IngredientDTO>()
                .IncludeMembers(si => si.Ingredient)
                .ForMember(ssc => ssc.Id, c => c.MapFrom(si => si.Ingredient.Id));

            CreateMap<Ingredient, IngredientDTO>()
                .ForMember(idto => idto.Amount, c => c.Ignore());

            CreateMap<Ingredient, IngredientListDTO>();

            CreateMap<MainCategory, MainCategoryDTO>();

            CreateMap<CreateSushiDTO, Sushi>()
                .ForMember(sushi => sushi.Description,
                c => c.MapFrom(csdto =>
                new SushiDescription()
                {
                    Description = csdto.Description,
                    IsDeleted = (int)IsDeleted.No,
                    LastModified = csdto.LastModified,
                    Created = csdto.Created
                }))
                .ForMember(sushi => sushi.sushiIngredients, c => c.MapFrom(csdto => csdto.SushiIngredients));

            CreateMap<CreateSushiIngredientDTO, SushiIngredient>();
        }
    }
}
