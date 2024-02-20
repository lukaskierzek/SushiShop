namespace SushiShopAngular.Server.Models
{
    public class SushiDescription
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public int SushiId { get; set; }
        public virtual Sushi Sushi { get; set; } = null!;
        public int IsDeleted { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime LastModified { get; set; } = DateTime.UtcNow;
    }
}
