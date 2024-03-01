using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SushiShopAngular.Server.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(38), new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(41), new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(44), new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9948), new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9951), new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9953), new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(80), new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(83), new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(86), new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "SushiIngredient",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(212), new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "SushiIngredient",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(217), new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "SushiIngredient",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(215), new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 1, 1 },
                column: "Created",
                value: new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 1, 2 },
                column: "Created",
                value: new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 2, 1 },
                column: "Created",
                value: new DateTime(2024, 2, 29, 20, 35, 55, 931, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9822), new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9826), new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9830), new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9834), new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9989), new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9993), new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9996), new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9999), new DateTime(2024, 2, 29, 20, 35, 55, 930, DateTimeKind.Utc).AddTicks(9999) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5842), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5846), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5848), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5721), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5724), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5726), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5884), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5886), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "SushiIngredient",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5949), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "SushiIngredient",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5953), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "SushiIngredient",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5951), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 1, 1 },
                column: "Created",
                value: new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 1, 2 },
                column: "Created",
                value: new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 2, 1 },
                column: "Created",
                value: new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5638), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5643), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5646), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5761), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5764), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5803), new DateTime(2024, 2, 29, 10, 46, 36, 819, DateTimeKind.Utc).AddTicks(5803) });
        }
    }
}
