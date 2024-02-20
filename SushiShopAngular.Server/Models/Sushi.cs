namespace SushiShopAngular.Server.Models
{
    public class Sushi
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal ActualPrice { get; set; }
        public decimal OldPrice { get; set; }
        public virtual SushiDescription? Description { get; set; }
        public int MainCategoryId { get; set; }
        public virtual MainCategory MainCategory { get; set; } = null!;
        public List<SubCategory> SubCategories { get; } = [];
        public List<Ingredient> Ingredients { get; } = [];
        public int IsDeleted { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime LastModified { get; set; } = DateTime.UtcNow;
    }
}
