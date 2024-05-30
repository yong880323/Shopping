using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.Migrations
{
    /// <inheritdoc />
    public partial class AddShoppingTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Param",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tag = table.Column<int>(type: "int", nullable: false),
                    Seq_no = table.Column<int>(type: "int", nullable: false),
                    CONT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Param", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shoporder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoporder", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Param",
                columns: new[] { "Id", "CONT", "Seq_no", "Tag" },
                values: new object[,]
                {
                    { 1, "Payment completed", 1, 1 },
                    { 2, "To be shipped", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Shoporder",
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
            migrationBuilder.DropTable(
                name: "Param");

            migrationBuilder.DropTable(
                name: "Shoporder");
        }
    }
}
