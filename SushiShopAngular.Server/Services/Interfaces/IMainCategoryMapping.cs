using SushiShopAngular.Server.Models.ModelsDTO;
using SushiShopAngular.Server.Models;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface IMainCategoryMapping
    {
        List<MainCategoryDTO> GetAllMainCategoryDTO(List<MainCategory> sushi);
    }
}
