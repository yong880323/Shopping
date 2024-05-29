using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderName",
                table: "Shoporders",
                newName: "OrderItem");

            migrationBuilder.InsertData(
                table: "Shoporders",
                columns: new[] { "Id", "Cost", "OrderId", "OrderItem", "Price", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 90, "A20202026001", "Product1", 100, 1, 1 },
                    { 2, 100, "A20202023001", "Product2", 120, 1, 1 },
                    { 3, 150, "A20202026002", "Product3", 200, 1, 1 },
                    { 4, 120, "A20202024003", "Product4", 150, 1, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shoporders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shoporders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shoporders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shoporders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "OrderItem",
                table: "Shoporders",
                newName: "OrderName");
        }
    }
}
