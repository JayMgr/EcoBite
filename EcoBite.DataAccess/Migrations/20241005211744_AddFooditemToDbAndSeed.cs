using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcoBiteBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFooditemToDbAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fooditems",
                columns: table => new
                {
                    FooditemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fooditems", x => x.FooditemId);
                });

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
            migrationBuilder.DropTable(
                name: "Fooditems");
        }
    }
}
