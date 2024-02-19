namespace SushiShopAngular.Server.Models
{
    public class Sushi
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double ActualPrice { get; set; }
        public double OldPrice { get; set; }
        public virtual SushiDescription Description { get; set; } = null!;
        public int MainCategoryId { get; set; }
        public virtual MainCategory MainCategory { get; set; } = null!;
        public List<SubCategory> SubCategories { get; } = [];
        public List<Ingredient> Ingredients { get; } = [];
        public int IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}
