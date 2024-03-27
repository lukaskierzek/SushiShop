using Microsoft.EntityFrameworkCore;
using SushiShopAngular.Server.Data;
using SushiShopAngular.Server.Services.Classes;
using SushiShopAngular.Server.Services.Interfaces;
using System.Text.Json.Serialization;

namespace SushiShopAngular.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionStringSushiShopDefaultDatabaseMSSQL = builder.Configuration.GetConnectionString("DefaultSushiShopDatabaseMSSQL");

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            }
            );
            builder.Services.AddDbContext<SushiShopContext>(
                    options =>
                    {
                        options.UseSqlServer(connectionStringSushiShopDefaultDatabaseMSSQL)
                        .LogTo(Console.WriteLine, LogLevel.Information);
                        options.EnableSensitiveDataLogging();
                    }
                );

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddAutoMapper(typeof(Program).Assembly);

            builder.Services.AddScoped<ISushiService, SushiService>();
            builder.Services.AddScoped<IMainCategoryService, MainCategoryService>();
            builder.Services.AddScoped<IIngredientService, IngredientService>();

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(options =>
                options.WithOrigins("https://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyMethod()
            );
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
