using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SushiShopAngular.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIngredient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7657), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified", "Name" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7660), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7661), "Ingredient2" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7664), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7497), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7500), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7503), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7699), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7703), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7706), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "SushiIngredient",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7776), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "SushiIngredient",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7779), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "SushiIngredient",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7777), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 1, 1 },
                column: "Created",
                value: new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 1, 2 },
                column: "Created",
                value: new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 2, 1 },
                column: "Created",
                value: new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7408), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7414), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7418), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7422), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7608), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7612), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7615), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7617), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7618) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4139), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified", "Name" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4143), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4143), "Ingredient3" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4146), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4040), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4043), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4046), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4180), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4184), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4187), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "SushiIngredient",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4260), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "SushiIngredient",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4264), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "SushiIngredient",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4263), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 1, 1 },
                column: "Created",
                value: new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 1, 2 },
                column: "Created",
                value: new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 2, 1 },
                column: "Created",
                value: new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3947), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3952), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3956), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3960), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4085), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4089), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4093), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4096), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4096) });
        }
    }
}
