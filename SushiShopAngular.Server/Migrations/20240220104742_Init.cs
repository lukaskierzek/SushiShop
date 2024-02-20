using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                name: "IngredientSushi",
                columns: table => new
                {
                    IngredientsId = table.Column<int>(type: "int", nullable: false),
                    SushisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientSushi", x => new { x.IngredientsId, x.SushisId });
                    table.ForeignKey(
                        name: "FK_IngredientSushi_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientSushi_Sushis_SushisId",
                        column: x => x.SushisId,
                        principalTable: "Sushis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategorySushi",
                columns: table => new
                {
                    SubCategoriesId = table.Column<int>(type: "int", nullable: false),
                    SushisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorySushi", x => new { x.SubCategoriesId, x.SushisId });
                    table.ForeignKey(
                        name: "FK_SubCategorySushi_SubCategories_SubCategoriesId",
                        column: x => x.SubCategoriesId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubCategorySushi_Sushis_SushisId",
                        column: x => x.SushisId,
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

            migrationBuilder.CreateIndex(
                name: "IX_IngredientSushi_SushisId",
                table: "IngredientSushi",
                column: "SushisId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorySushi_SushisId",
                table: "SubCategorySushi",
                column: "SushisId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientSushi");

            migrationBuilder.DropTable(
                name: "SubCategorySushi");

            migrationBuilder.DropTable(
                name: "SushisDescriptions");

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
