using SushiShopAngular.Server.Models;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface ISushi
    {
        bool AnySushi(int id);
        Task<Sushi> CreateSushi(Sushi sushi, List<SushiIngredient> sushiIngredients);
        Task<List<Sushi>> GetAllSushi();
        Task<Sushi> GetSushiById(int id);
        Task<Sushi> UpdateSushi(Sushi sushi);
    }
}
