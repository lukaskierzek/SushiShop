using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO;

namespace SushiShopAngular.Server.ExtensionMethods
{
    public static class ModelExtensions
    {
        public static bool IsNull(this Sushi? sushi) => sushi == null;
        public static bool IsNull(this SushiDTO sushiDTO) => sushiDTO == null;
    }
}
