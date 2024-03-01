using Microsoft.EntityFrameworkCore;
using SushiShopAngular.Server.Enums;
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
                .WithMany(subCategory => subCategory.Sushis)
                .UsingEntity<SushiSubCategory>();

            modelBuilder.Entity<Sushi>()
                .HasMany(sushi => sushi.Ingredients)
                .WithMany(ingredient => ingredient.Sushis)
                .UsingEntity<SushiIngredient>();
            #endregion

            #region EntitySushiDescription
            modelBuilder.Entity<SushiDescription>()
                .Property(sh => sh.Description)
                .HasMaxLength(500);

            modelBuilder.Entity<SushiDescription>()
                .Property(sh => sh.IsDeleted)
                .HasMaxLength(1);
            #endregion

            #region EntityMainCategory
            modelBuilder.Entity<MainCategory>()
                .Property(mc => mc.Name)
                .HasMaxLength(255);

            modelBuilder.Entity<MainCategory>()
                .Property(mc => mc.IsDeleted)
                .HasMaxLength(1);
            #endregion

            #region EntitySubCategory
            modelBuilder.Entity<SubCategory>()
                .Property(sb => sb.Name)
                .HasMaxLength(255);

            modelBuilder.Entity<SubCategory>()
                .Property(sb => sb.IsDeleted)
                .HasMaxLength(1);
            #endregion

            #region EntityIngredient
            modelBuilder.Entity<Ingredient>()
                .Property(i => i.Name)
                .HasMaxLength(255);

            modelBuilder.Entity<Ingredient>()
                .Property(i => i.IsDeleted)
                .HasMaxLength(1);
            #endregion

            #region SushiIngredient
            modelBuilder.Entity<SushiIngredient>()
                .ToTable(tb => tb.HasCheckConstraint("CK_SushiIngredient_RangeAmount", "Amount >= 0 AND Amount <=100"));
            #endregion

            #region SeedDataSushi
            var sushi1 = new Sushi { Id = 1, Name = "Sushi1", ActualPrice = 10, OldPrice = 10, MainCategoryId = 1, IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };
            var sushi2 = new Sushi { Id = 2, Name = "Sushi2", ActualPrice = 10, OldPrice = 9, MainCategoryId = 2, IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };
            var sushi3 = new Sushi { Id = 3, Name = "Sushi3", ActualPrice = 10, OldPrice = 20, MainCategoryId = 3, IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };
            var sushi4 = new Sushi { Id = 4, Name = "Sushi4", ActualPrice = 10, OldPrice = 20, MainCategoryId = 3, IsDeleted = (int)IsDeleted.Yes, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };

            var sushi = new List<Sushi> { sushi1, sushi2, sushi3, sushi4 };
            modelBuilder.Entity<Sushi>().HasData(sushi);
            #endregion

            #region SeedDataMainCategory
            var mainCategory1 = new MainCategory { Id = 1, Name = "Main category 1", IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };
            var mainCategory2 = new MainCategory { Id = 2, Name = "Main category 2", IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };
            var mainCategory3 = new MainCategory { Id = 3, Name = "Main category 3", IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };

            var mainCategory = new List<MainCategory> { mainCategory1, mainCategory2, mainCategory3 };
            modelBuilder.Entity<MainCategory>().HasData(mainCategory);
            #endregion

            #region SeedDataSushiDescription
            var sushiDescription1 = new SushiDescription { Id = 1, Description = "SushiDescription1", SushiId = 1, IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };
            var sushiDescription2 = new SushiDescription { Id = 2, Description = "SushiDescription2", SushiId = 2, IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };
            var sushiDescription3 = new SushiDescription { Id = 3, Description = "SushiDescription3", SushiId = 3, IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };
            var sushiDescription4 = new SushiDescription { Id = 4, Description = "SushiDescription4", SushiId = 4, IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };

            var sushiDecsription = new List<SushiDescription> { sushiDescription1, sushiDescription2, sushiDescription3, sushiDescription4 };
            modelBuilder.Entity<SushiDescription>().HasData(sushiDecsription);
            #endregion

            #region SeedDataIngredient
            var ingredient1 = new Ingredient { Id = 1, Name = "Ingredient1", IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };
            var ingredient2 = new Ingredient { Id = 2, Name = "Ingredient3", IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };
            var ingredient3 = new Ingredient { Id = 3, Name = "Ingredient3", IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };

            var ingredient = new List<Ingredient> { ingredient1, ingredient2, ingredient3 };
            modelBuilder.Entity<Ingredient>().HasData(ingredient);
            #endregion

            #region SeedDataSubCategory
            var subCategory1 = new SubCategory { Id = 1, Name = "subCategory1", IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };
            var subCategory2 = new SubCategory { Id = 2, Name = "subCategory2", IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };
            var subCategory3 = new SubCategory { Id = 3, Name = "subCategory3", IsDeleted = (int)IsDeleted.No, Created = DateTime.UtcNow, LastModified = DateTime.UtcNow, };

            var subCategory = new List<SubCategory> { subCategory1, subCategory2, subCategory3 };
            modelBuilder.Entity<SubCategory>().HasData(subCategory);
            #endregion

            #region SeedDataSushiSubCategory
            var sushiSubCategory1 = new SushiSubCategory { SushiId = 1, SubCategoryId = 1 };
            var sushiSubCategory2 = new SushiSubCategory { SushiId = 1, SubCategoryId = 2 };
            var sushiSubCategory3 = new SushiSubCategory { SushiId = 2, SubCategoryId = 1 };

            var sushiSubCategory = new List<SushiSubCategory> { sushiSubCategory1, sushiSubCategory2, sushiSubCategory3 };
            modelBuilder.Entity<SushiSubCategory>().HasData(sushiSubCategory);
            #endregion

            #region SeedSushiIngredient
            var sushiIngredient1 = new SushiIngredient { SushiId = 1, IngredientId = 1, Amount = 1 };
            var sushiIngredient2 = new SushiIngredient { SushiId = 1, IngredientId = 2, Amount = 2 };
            var sushiIngredient3 = new SushiIngredient { SushiId = 2, IngredientId = 1, Amount = 3 };

            var sushiIngredient = new List<SushiIngredient> { sushiIngredient1, sushiIngredient2, sushiIngredient3 };
            modelBuilder.Entity<SushiIngredient>().HasData(sushiIngredient);
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
