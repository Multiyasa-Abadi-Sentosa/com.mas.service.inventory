using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.Danliris.Service.Inventory.Lib.Migrations
{
    public partial class Add_Column_Buyer_NoPo_Inventory_Table : Migration
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

            migrationBuilder.CreateTable(
                name: "IntegrationLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    LastIntegrationDate = table.Column<DateTimeOffset>(nullable: false),
                    Remark = table.Column<string>(maxLength: 100, nullable: true),
                    _CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    _CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    _CreatedUtc = table.Column<DateTime>(nullable: false),
                    _DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    _DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    _DeletedUtc = table.Column<DateTime>(nullable: false),
                    _IsDeleted = table.Column<bool>(nullable: false),
                    _LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    _LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    _LastModifiedUtc = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegrationLog", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntegrationLog");

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
