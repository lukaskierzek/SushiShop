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
                name: "SushiIngredient",
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
                    table.PrimaryKey("PK_SushiIngredient", x => new { x.IngredientId, x.SushiId });
                    table.CheckConstraint("CK_SushiIngredient_RangeAmount", "Amount >= 0 AND Amount <=100");
                    table.ForeignKey(
                        name: "FK_SushiIngredient_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SushiIngredient_Sushis_SushiId",
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
                    { 1, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5842), 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5843), "Ingredient1" },
                    { 2, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5846), 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5846), "Ingredient3" },
                    { 3, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5848), 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5849), "Ingredient3" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5721), 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5722), "Main category 1" },
                    { 2, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5724), 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5724), "Main category 2" },
                    { 3, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5726), 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5727), "Main category 3" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5880), 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5881), "subCategory1" },
                    { 2, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5884), 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5884), "subCategory2" },
                    { 3, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5886), 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5887), "subCategory3" }
                });

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "Id", "ActualPrice", "Created", "IsDeleted", "LastModified", "MainCategoryId", "Name", "OldPrice" },
                values: new object[,]
                {
                    { 1, 10m, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5638), 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5639), 1, "Sushi1", 10m },
                    { 2, 10m, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5643), 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5643), 2, "Sushi2", 9m },
                    { 3, 10m, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5646), 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5647), 3, "Sushi3", 20m },
                    { 4, 10m, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5650), 1, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5651), 3, "Sushi4", 20m }
                });

            migrationBuilder.InsertData(
                table: "SushiIngredient",
                columns: new[] { "IngredientId", "SushiId", "Amount", "Created", "LastModified" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5949), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5949) },
                    { 1, 2, 3, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5953), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5953) },
                    { 2, 1, 2, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5951), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5952) }
                });

            migrationBuilder.InsertData(
                table: "SushiSubCategory",
                columns: new[] { "SubCategoryId", "SushiId", "Created" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5916) },
                    { 1, 2, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5919) },
                    { 2, 1, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5918) }
                });

            migrationBuilder.InsertData(
                table: "SushisDescriptions",
                columns: new[] { "Id", "Created", "Description", "IsDeleted", "LastModified", "SushiId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5761), "SushiDescription1", 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5762), 1 },
                    { 2, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5764), "SushiDescription2", 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5765), 2 },
                    { 3, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5800), "SushiDescription3", 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5801), 3 },
                    { 4, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5803), "SushiDescription4", 0, new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5803), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SushiIngredient_SushiId",
                table: "SushiIngredient",
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
                name: "SushiIngredient");

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
