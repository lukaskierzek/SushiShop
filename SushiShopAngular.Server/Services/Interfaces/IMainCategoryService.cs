using SushiShopAngular.Server.Models;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface IMainCategoryService : IMainCategoryMapping
    {
        Task<List<MainCategory>> GetAllMainCategory();
    }
}