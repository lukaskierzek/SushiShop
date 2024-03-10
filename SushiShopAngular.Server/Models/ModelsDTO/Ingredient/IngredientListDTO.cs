namespace SushiShopAngular.Server.Models.ModelsDTO.Ingredient
{
    public record IngredientListDTO
    {
        public required int Id { get; init; }
        public required string Name { get; init; }
    }
}
