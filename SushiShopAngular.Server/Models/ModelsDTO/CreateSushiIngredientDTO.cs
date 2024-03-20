namespace SushiShopAngular.Server.Models.ModelsDTO
{
    public record CreateSushiIngredientDTO
    {
        public required int SushiId { get; init; }
        public required int IngredientId { get; init; }
        public required int Amount { get; init; }
        public required DateTime Created { get; init; } = DateTime.UtcNow;
        public required DateTime LastModified { get; init; } = DateTime.UtcNow;
    }
}
