using SushiShopAngular.Server.Models;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface IIngredientService : IIngredientMapping
    {
        Task<List<Ingredient>> GetAllIngredient();
    }
}
