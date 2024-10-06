using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcoBiteBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addInventoriesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryId);
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "InventoryId", "DateAdded", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 6, 12, 32, 29, 312, DateTimeKind.Local).AddTicks(9352), 50 },
                    { 2, new DateTime(2024, 10, 5, 12, 32, 29, 312, DateTimeKind.Local).AddTicks(9364), 30 },
                    { 3, new DateTime(2024, 10, 4, 12, 32, 29, 312, DateTimeKind.Local).AddTicks(9370), 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");
        }
    }
}
