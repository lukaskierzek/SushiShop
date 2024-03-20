using SushiShopAngular.Server.Models.ModelsDTO.Ingredient;
using SushiShopAngular.Server.Models.ModelsDTO.Sushi;
using SushiShopAngular.Server.Models.ModelsDTO;
using SushiShopAngular.Server.Models;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface ISushiMapping
    {
        List<SushiDTO> GetAllSushiDTO(List<Sushi> sushi);
        SushiDTO GetSushiByIdDTO(Sushi sushi);
        Sushi CreateSushiFromSushiDTO(CreateSushiDTO createSushiDTO);
        List<MainCategoryDTO> GetAllMainCategoryDTO(List<MainCategory> sushi);
        List<IngredientListDTO> GetAllIngredientDTO(List<Ingredient> ingredients);
        List<SushiIngredient> GetSushiIngredientDTOFromSushiPOST(List<CreateSushiIngredientDTO> ingredients);
    }
}
