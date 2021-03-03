using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Danliris.Service.Inventory.Lib.Migrations
{
    public partial class Add_Column_Buyer_NoPOBuyer_Inventory_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BuyerCode",
                table: "InventoryDocuments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BuyerId",
                table: "InventoryDocuments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BuyerName",
                table: "InventoryDocuments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoPOBuyer",
                table: "InventoryDocuments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyerCode",
                table: "InventoryDocuments");

            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "InventoryDocuments");

            migrationBuilder.DropColumn(
                name: "BuyerName",
                table: "InventoryDocuments");

            migrationBuilder.DropColumn(
                name: "NoPOBuyer",
                table: "InventoryDocuments");
        }
    }
}
