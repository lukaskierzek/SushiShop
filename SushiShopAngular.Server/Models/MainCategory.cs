namespace SushiShopAngular.Server.Models
{
    public class MainCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<Sushi> Sushis { get; set; } = null!;
        public int IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}
