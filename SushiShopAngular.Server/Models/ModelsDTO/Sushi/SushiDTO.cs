using SushiShopAngular.Server.Models.ModelsDTO.Ingredient;

namespace SushiShopAngular.Server.Models.ModelsDTO.Sushi
{
    public record SushiDTO
    {
        public required int Id { get; init; }
        public required string Name { get; init; }
        public required decimal ActualPrice { get; init; }
        public required decimal OldPrice { get; init; }
        public required string Description { get; init; }
        public required string MainCategory { get; init; }
        public required string ImageUrl { get; init; }
        public required List<IngredientDTO> ingredients { get; init; }
        public required List<SubCategoryDTO> SubCategories { get; init; }
        public required int IsDeleted { get; init; }
        public DateTime LastModified { get; set; } = DateTime.UtcNow;
    }
}
