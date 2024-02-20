using Microsoft.EntityFrameworkCore;
using SushiShopAngular.Server.Models;

namespace SushiShopAngular.Server.Data
{
    public class SushiShopContext : DbContext
    {
        public DbSet<Sushi> Sushis { get; set; } = null!;
        public DbSet<SushiDescription> SushisDescriptions { get; set; } = null!;
        public DbSet<MainCategory> MainCategories { get; set; } = null!;
        public DbSet<SubCategory> SubCategories { get; set; } = null!;
        public DbSet<Ingredient> Ingredients { get; set; } = null!;

        public SushiShopContext(DbContextOptions<SushiShopContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region EntitySushi
            modelBuilder.Entity<Sushi>()
                .Property(sushi => sushi.Name)
                .HasMaxLength(255);

            modelBuilder.Entity<Sushi>()
                .Property(sushi => sushi.ActualPrice)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Sushi>()
                .Property(sushi => sushi.OldPrice)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Sushi>()
                .Property(sushi => sushi.IsDeleted)
                .HasMaxLength(1);

            modelBuilder.Entity<Sushi>()
                .HasOne(sushi => sushi.Description)
                .WithOne(sushiDescription => sushiDescription.Sushi)
                .HasForeignKey<SushiDescription>(sushiDescription => sushiDescription.SushiId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            modelBuilder.Entity<Sushi>()
                .HasOne(sushi => sushi.MainCategory)
                .WithMany(mainCategory => mainCategory.Sushis)
                .HasForeignKey(sushi => sushi.MainCategoryId);

            modelBuilder.Entity<Sushi>()
                .HasMany(sushi => sushi.SubCategories)
                .WithMany(subCategory => subCategory.Sushis);

            modelBuilder.Entity<Sushi>()
                .HasMany(sushi => sushi.Ingredients)
                .WithMany(ingredient => ingredient.Sushis);
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
