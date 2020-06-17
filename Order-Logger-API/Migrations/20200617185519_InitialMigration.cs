using Microsoft.EntityFrameworkCore.Migrations;

namespace Order_Logger_API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(8)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");
        }
    }
}
