namespace SushiShopAngular.Server.Models.ModelsDTO.Sushi
{
    public record CreateSushiDTO
    {
        public required string Name { get; init; }
        public required decimal ActualPrice { get; init; }
        public required decimal OldPrice { get; init; }
        public required string Description { get; init; }
        public required int MainCategoryId { get; set; }
        public required string ImageUrl { get; init; }
        public required int IsDeleted { get; init; }
        public required List<CreateSushiIngredientDTO> SushiIngredients { get; init; }
        //public required List<CreateSushiSubCategoryDTO> subCategories { get; init; }
        public required DateTime Created { get; init; } = DateTime.UtcNow;
        public required DateTime LastModified { get; init; } = DateTime.UtcNow;
    }
}
