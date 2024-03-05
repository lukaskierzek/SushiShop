using AutoMapper;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO;

namespace SushiShopAngular.Server.Mapping
{
    public class SushiMapping : Profile
    {
        public SushiMapping()
        {
            CreateMap<Sushi, SushiDTO>()
                .ForMember(sushidto => sushidto.Description, c => c.MapFrom(sushi => sushi.Description.Description))
                .ForMember(sushidto => sushidto.MainCategory, c => c.MapFrom(sushi => sushi.MainCategory.Name))
                //.ForMember(sushidto => sushidto.Ingrediets, c => c.MapFrom(sushi => sushi.sushiIngredients.Select(y => y.Ingredient).ToList()))
                .ForMember(sushidto => sushidto.Ingrediets, c => c.MapFrom(sushi => sushi.sushiIngredients))
                .ForMember(sushidto => sushidto.SubCategories, c => c.MapFrom(sushi => sushi.sushiSubCategories.Select(y => y.SubCategory).ToList()));

            CreateMap<SubCategory, SubCategoryDTO>();

            CreateMap<SushiIngredient, IngredientDTO>().IncludeMembers(src => src.Ingredient).ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Ingredient.Id));
            CreateMap<Ingredient, IngredientDTO>().ForMember(idto => idto.Amount, c => c.Ignore());

            CreateMap<MainCategory, MainCategoryDTO>();
        }
    }
}
