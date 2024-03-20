using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SushiShopAngular.Server.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sushis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ActualPrice = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    OldPrice = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    MainCategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    IsDeleted = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sushis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sushis_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SushiIngredients",
                columns: table => new
                {
                    SushiId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SushiIngredients", x => new { x.IngredientId, x.SushiId });
                    table.CheckConstraint("CK_SushiIngredient_RangeAmount", "Amount >= 0 AND Amount <=100");
                    table.ForeignKey(
                        name: "FK_SushiIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SushiIngredients_Sushis_SushiId",
                        column: x => x.SushiId,
                        principalTable: "Sushis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SushisDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SushiId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SushisDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SushisDescriptions_Sushis_SushiId",
                        column: x => x.SushiId,
                        principalTable: "Sushis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "SushiSubCategory",
                columns: table => new
                {
                    SushiId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SushiSubCategory", x => new { x.SubCategoryId, x.SushiId });
                    table.ForeignKey(
                        name: "FK_SushiSubCategory_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SushiSubCategory_Sushis_SushiId",
                        column: x => x.SushiId,
                        principalTable: "Sushis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4466), 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4467), "Ingredient1" },
                    { 2, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4470), 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4470), "Ingredient2" },
                    { 3, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4473), 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4473), "Ingredient3" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4382), 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4382), "Main category 1" },
                    { 2, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4385), 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4385), "Main category 2" },
                    { 3, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4387), 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4388), "Main category 3" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4504), 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4504), "subCategory1" },
                    { 2, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4507), 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4508), "subCategory2" },
                    { 3, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4510), 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4510), "subCategory3" }
                });

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "Id", "ActualPrice", "Created", "ImageUrl", "IsDeleted", "LastModified", "MainCategoryId", "Name", "OldPrice" },
                values: new object[,]
                {
                    { 1, 10m, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4298), "https://img.freepik.com/free-photo/freshness-plate-gourmet-seafood-maki-sushi-avocado-sashimi-generated-by-artificial-intelligence_25030-66337.jpg?w=1380&t=st=1709289227~exp=1709289827~hmac=b87b76aed267433a4760bd9582f1c8b8ca8564915573edeb67ebf356a0b3eb3f", 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4298), 1, "Sushi1", 10m },
                    { 2, 10m, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4302), "https://img.freepik.com/free-photo/freshness-plate-gourmet-seafood-maki-sushi-avocado-sashimi-generated-by-artificial-intelligence_25030-66337.jpg?w=1380&t=st=1709289227~exp=1709289827~hmac=b87b76aed267433a4760bd9582f1c8b8ca8564915573edeb67ebf356a0b3eb3f", 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4303), 2, "Sushi2", 9m },
                    { 3, 10m, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4306), "https://img.freepik.com/free-photo/freshness-plate-gourmet-seafood-maki-sushi-avocado-sashimi-generated-by-artificial-intelligence_25030-66337.jpg?w=1380&t=st=1709289227~exp=1709289827~hmac=b87b76aed267433a4760bd9582f1c8b8ca8564915573edeb67ebf356a0b3eb3f", 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4307), 3, "Sushi3", 20m },
                    { 4, 10m, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4310), "https://img.freepik.com/free-photo/freshness-plate-gourmet-seafood-maki-sushi-avocado-sashimi-generated-by-artificial-intelligence_25030-66337.jpg?w=1380&t=st=1709289227~exp=1709289827~hmac=b87b76aed267433a4760bd9582f1c8b8ca8564915573edeb67ebf356a0b3eb3f", 1, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4311), 3, "Sushi4", 20m }
                });

            migrationBuilder.InsertData(
                table: "SushiIngredients",
                columns: new[] { "IngredientId", "SushiId", "Amount", "Created", "LastModified" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4637), new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4637) },
                    { 1, 2, 3, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4641), new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4641) },
                    { 2, 1, 2, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4639), new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4640) }
                });

            migrationBuilder.InsertData(
                table: "SushiSubCategory",
                columns: new[] { "SubCategoryId", "SushiId", "Created" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4594) },
                    { 1, 2, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4600) },
                    { 2, 1, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4599) }
                });

            migrationBuilder.InsertData(
                table: "SushisDescriptions",
                columns: new[] { "Id", "Created", "Description", "IsDeleted", "LastModified", "SushiId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4422), "SushiDescription1", 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4423), 1 },
                    { 2, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4425), "SushiDescription2", 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4426), 2 },
                    { 3, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4428), "SushiDescription3", 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4428), 3 },
                    { 4, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4431), "SushiDescription4", 0, new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4431), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SushiIngredients_SushiId",
                table: "SushiIngredients",
                column: "SushiId");

            migrationBuilder.CreateIndex(
                name: "IX_Sushis_MainCategoryId",
                table: "Sushis",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SushisDescriptions_SushiId",
                table: "SushisDescriptions",
                column: "SushiId",
                unique: true,
                filter: "[SushiId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SushiSubCategory_SushiId",
                table: "SushiSubCategory",
                column: "SushiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SushiIngredients");

            migrationBuilder.DropTable(
                name: "SushisDescriptions");

            migrationBuilder.DropTable(
                name: "SushiSubCategory");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Sushis");

            migrationBuilder.DropTable(
                name: "MainCategories");
        }
    }
}
