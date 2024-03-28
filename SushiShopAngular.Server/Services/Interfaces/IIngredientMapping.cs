using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO.Ingredient;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface IIngredientMapping
    {
        List<IngredientListDTO> GetAllIngredientDTO(List<Ingredient> ingredients);
    }
}
