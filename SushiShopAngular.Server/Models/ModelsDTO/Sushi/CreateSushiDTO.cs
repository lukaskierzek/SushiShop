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
        public int IsDeleted { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime LastModified { get; set; } = DateTime.UtcNow;
    }
}
