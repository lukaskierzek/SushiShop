namespace SushiShopAngular.Server.Models
{
    public class SushiSubCategory
    {
        public int SushiId { get; set; }
        public int SubCategoryId { get; set; }
        public virtual Sushi Sushi { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
