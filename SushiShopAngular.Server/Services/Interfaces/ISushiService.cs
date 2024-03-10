using SushiShopAngular.Server.Models.ModelsDTO;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO.Sushi;
using SushiShopAngular.Server.Models.ModelsDTO.Ingredient;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface ISushiService
    {
        List<SushiDTO> GetAllSushiDTO(List<Sushi> sushi);
        SushiDTO GetSushiByIdDTO(Sushi sushi);
        Sushi CreateSushiFromSushiDTO(CreateSushiDTO createSushiDTO);
        List<MainCategoryDTO> GetAllMainCategoryDTO(List<MainCategory> sushi);
        List<IngredientListDTO> GetAllIngredientDTO(List<Ingredient> ingredients);

    }
}
