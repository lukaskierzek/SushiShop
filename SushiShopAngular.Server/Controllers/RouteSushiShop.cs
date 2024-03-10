namespace SushiShopAngular.Server.Controllers
{
    public static class RouteSushiShop
    {
        public const string MainRoute = "sushi-shop";

        #region Sushi
        public const string AllSushi = "sushi";
        public const string SushiById = AllSushi + "/{id}";
        #endregion

        #region Category
        public const string AllMainCategory = "main-category";
        #endregion

        #region Ingredient
        public const string AllIngredient = "ingredient";
        #endregion
    }
}
