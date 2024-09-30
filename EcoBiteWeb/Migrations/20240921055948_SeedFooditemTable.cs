using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcoBiteWeb.Migrations
{
    /// <inheritdoc />
    public partial class SeedFooditemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fooditems",
                columns: new[] { "FooditemId", "Description", "ExpirationDate", "Name" },
                values: new object[,]
                {
                    { 1, "Available", "29 days", "Rice" },
                    { 2, "Availabel", "5 days", "Burger" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fooditems",
                keyColumn: "FooditemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fooditems",
                keyColumn: "FooditemId",
                keyValue: 2);
        }
    }
}
