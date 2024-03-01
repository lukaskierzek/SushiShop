using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SushiShopAngular.Server.Migrations
{
    /// <inheritdoc />
    public partial class SushImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Sushis",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4143), new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(4143) });

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
                columns: new[] { "Created", "ImageUrl", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3947), "https://img.freepik.com/free-photo/freshness-plate-gourmet-seafood-maki-sushi-avocado-sashimi-generated-by-artificial-intelligence_25030-66337.jpg?w=1380&t=st=1709289227~exp=1709289827~hmac=b87b76aed267433a4760bd9582f1c8b8ca8564915573edeb67ebf356a0b3eb3f", new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ImageUrl", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3952), "https://img.freepik.com/free-photo/freshness-plate-gourmet-seafood-maki-sushi-avocado-sashimi-generated-by-artificial-intelligence_25030-66337.jpg?w=1380&t=st=1709289227~exp=1709289827~hmac=b87b76aed267433a4760bd9582f1c8b8ca8564915573edeb67ebf356a0b3eb3f", new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "ImageUrl", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3956), "https://img.freepik.com/free-photo/freshness-plate-gourmet-seafood-maki-sushi-avocado-sashimi-generated-by-artificial-intelligence_25030-66337.jpg?w=1380&t=st=1709289227~exp=1709289827~hmac=b87b76aed267433a4760bd9582f1c8b8ca8564915573edeb67ebf356a0b3eb3f", new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "ImageUrl", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3960), "https://img.freepik.com/free-photo/freshness-plate-gourmet-seafood-maki-sushi-avocado-sashimi-generated-by-artificial-intelligence_25030-66337.jpg?w=1380&t=st=1709289227~exp=1709289827~hmac=b87b76aed267433a4760bd9582f1c8b8ca8564915573edeb67ebf356a0b3eb3f", new DateTime(2024, 3, 1, 10, 37, 18, 327, DateTimeKind.Utc).AddTicks(3961) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Sushis");

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
    }
}
