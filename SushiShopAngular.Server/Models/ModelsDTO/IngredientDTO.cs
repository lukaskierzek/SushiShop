namespace SushiShopAngular.Server.Models.ModelsDTO
{
    public record IngredientDTO
    {
        //public required int Id { get; set; }
        public required string Name { get; init; }
        public required int Amount { get; init; }
    }
}