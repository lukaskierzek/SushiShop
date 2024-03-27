using SushiShopAngular.Server.Models.ModelsDTO;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO.Sushi;
using SushiShopAngular.Server.Models.ModelsDTO.Ingredient;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface ISushiService : ISushiMapping
    {
        bool AnySushi(int id);
        Task<Sushi> CreateSushi(Sushi sushi, List<SushiIngredient> sushiIngredients);
        Task<List<Sushi>> GetAllSushi();
        Task<List<Sushi>> GetAllSushiByQuery(string mainCategoryName);
        Task<Sushi> GetSushiById(int id);
        Task<Sushi> UpdateSushi(Sushi sushi);
    }
}
