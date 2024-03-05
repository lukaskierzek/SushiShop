namespace SushiShopAngular.Server.Models.ModelsDTO
{
    public record MainCategoryDTO
    {
        public required int Id { get; init; }
        public required string Name { get; init; }
    }
}
