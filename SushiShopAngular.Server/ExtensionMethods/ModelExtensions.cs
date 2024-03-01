using SushiShopAngular.Server.Models;

namespace SushiShopAngular.Server.ExtensionMethods
{
    public static class ModelExtensions
    {
        public static bool IsNull(this Sushi? sushi) => sushi == null;
    }
}
