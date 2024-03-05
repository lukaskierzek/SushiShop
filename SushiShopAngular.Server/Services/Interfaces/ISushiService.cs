using SushiShopAngular.Server.Models.ModelsDTO;
using SushiShopAngular.Server.Models;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface ISushiService
    {
        List<SushiDTO> GetAllSushiDTO(List<Sushi> sushi);
        SushiDTO GetSushiByIdDTO(Sushi sushi);
        IEnumerable<MainCategoryDTO> GetAllMainCategoryDTO(List<MainCategory> sushi);
    }
}
