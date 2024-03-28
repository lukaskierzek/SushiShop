using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface IMainCategoryMapping
    {
        List<MainCategoryDTO> GetAllMainCategoryDTO(List<MainCategory> sushi);
    }
}
