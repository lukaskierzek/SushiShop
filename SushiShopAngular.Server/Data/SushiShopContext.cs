using Microsoft.EntityFrameworkCore;
using SushiShopAngular.Server.Models;

namespace SushiShopAngular.Server.Data
{
    public class SushiShopContext : DbContext
    {
        public DbSet<Sushi> Sushis { get; set; } = null!;
        public DbSet<SushiDescription> SushisDescriptions { get; set;} = null!;
        public DbSet<MainCategory> MainCategories { get; set; } = null!;
        public DbSet<SubCategory> SubCategories { get; set; } = null!;
        public DbSet<Ingredient> Ingredients { get; set; } = null!;
    }
}
