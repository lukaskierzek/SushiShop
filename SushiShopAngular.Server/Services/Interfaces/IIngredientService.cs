using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO.Ingredient;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface IIngredientService : IIngredientMapping
    {
        Task<List<Ingredient>> GetAllIngredient();
    }
}
