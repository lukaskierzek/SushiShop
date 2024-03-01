using SushiShopAngular.Server.Data;

namespace SushiShopAngular.Server.ExtensionMethods
{
    public static class SeedData
    {
        public static WebApplication Seed(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using var context = scope.ServiceProvider.GetRequiredService<SushiShopContext>();
                try
                {
                    context.Database.EnsureCreated();

                    var sushi = context.Sushis.FirstOrDefault();
                    if (sushi.IsNull())
                    {
                        context.Sushis.AddRange(
                                new Models.Sushi { }
                            );

                        context.SushisDescriptions.AddRange(
                                new Models.SushiDescription { }
                            );

                        context.MainCategories.AddRange(
                                new Models.MainCategory { }
                            );

                        context.SubCategories.AddRange(
                                new Models.SubCategory { }
                            );

                        context.Ingredients.AddRange(
                                new Models.Ingredient { }
                            );

                        //context.SaveChanges();
                    }
                }
                catch (Exception) { throw; }

                return app;
            }
        }
    }
}
