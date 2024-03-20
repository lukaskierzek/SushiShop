using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SushiShopAngular.Server.Migrations
{
    /// <inheritdoc />
    public partial class testup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SushiIngredient_Ingredients_IngredientId",
                table: "SushiIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_SushiIngredient_Sushis_SushiId",
                table: "SushiIngredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SushiIngredient",
                table: "SushiIngredient");

            migrationBuilder.RenameTable(
                name: "SushiIngredient",
                newName: "SushiIngredients");

            migrationBuilder.RenameIndex(
                name: "IX_SushiIngredient_SushiId",
                table: "SushiIngredients",
                newName: "IX_SushiIngredients_SushiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SushiIngredients",
                table: "SushiIngredients",
                columns: new[] { "IngredientId", "SushiId" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5526), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5529), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5532), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5372), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5376), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5378), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5566), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5572), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "SushiIngredients",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5633), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "SushiIngredients",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5638), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "SushiIngredients",
                keyColumns: new[] { "IngredientId", "SushiId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5637), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 1, 1 },
                column: "Created",
                value: new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 1, 2 },
                column: "Created",
                value: new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "SushiSubCategory",
                keyColumns: new[] { "SubCategoryId", "SushiId" },
                keyValues: new object[] { 2, 1 },
                column: "Created",
                value: new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5286), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5291), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5295), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5299), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5412), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5415), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5418), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "SushisDescriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 3, 18, 19, 57, 34, 994, DateTimeKind.Utc).AddTicks(5421) });

            migrationBuilder.AddForeignKey(
                name: "FK_SushiIngredients_Ingredients_IngredientId",
                table: "SushiIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SushiIngredients_Sushis_SushiId",
                table: "SushiIngredients",
                column: "SushiId",
                principalTable: "Sushis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SushiIngredients_Ingredients_IngredientId",
                table: "SushiIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_SushiIngredients_Sushis_SushiId",
                table: "SushiIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SushiIngredients",
                table: "SushiIngredients");

            migrationBuilder.RenameTable(
                name: "SushiIngredients",
                newName: "SushiIngredient");

            migrationBuilder.RenameIndex(
                name: "IX_SushiIngredients_SushiId",
                table: "SushiIngredient",
                newName: "IX_SushiIngredient_SushiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SushiIngredient",
                table: "SushiIngredient",
                columns: new[] { "IngredientId", "SushiId" });

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
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7660), new DateTime(2024, 3, 8, 19, 27, 31, 461, DateTimeKind.Utc).AddTicks(7661) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_SushiIngredient_Ingredients_IngredientId",
                table: "SushiIngredient",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SushiIngredient_Sushis_SushiId",
                table: "SushiIngredient",
                column: "SushiId",
                principalTable: "Sushis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
