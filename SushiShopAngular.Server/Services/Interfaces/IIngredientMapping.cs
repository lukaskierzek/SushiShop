using SushiShopAngular.Server.Models.ModelsDTO.Ingredient;
using SushiShopAngular.Server.Models;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface IIngredientMapping
    {
        List<IngredientListDTO> GetAllIngredientDTO(List<Ingredient> ingredients);
    }
}
