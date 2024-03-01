namespace SushiShopAngular.Server.Models.ModelsDTO
{
    public record SushiDTO
    {
        public required string Name { get; init; }
        public required decimal ActualPrice { get; init; }
        public required decimal OldPrice { get; init; }
        public required string Description { get; init; }
        public required string MainCategory { get; init; }
        public required List<IngredientDTO> Ingrediets { get; init; }
        public required List<SubCategoryDTO> SubCategories { get; init; }
    }
}
