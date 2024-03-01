using SushiShopAngular.Server.Models.ModelsDTO;
using SushiShopAngular.Server.Models;

namespace SushiShopAngular.Server.Services
{
    public interface ISushiService
    {
        IEnumerable<MainCategoryDTO> GetAllMainCategoryDTO(List<MainCategory> sushi);
    }
}
