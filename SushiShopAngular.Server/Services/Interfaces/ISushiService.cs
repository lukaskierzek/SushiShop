using SushiShopAngular.Server.Models.ModelsDTO;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO.Sushi;
using SushiShopAngular.Server.Models.ModelsDTO.Ingredient;

namespace SushiShopAngular.Server.Services.Interfaces
{
    public interface ISushiService : ISushiMapping, ISushi
    { }
}
