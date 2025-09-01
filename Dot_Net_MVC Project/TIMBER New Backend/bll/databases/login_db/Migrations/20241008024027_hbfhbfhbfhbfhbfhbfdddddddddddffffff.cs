using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class hbfhbfhbfhbfhbfhbfdddddddddddffffff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "warranty_visit_charge",
                table: "WarrantyExtendedItemTran",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "warranty_visit_gap",
                table: "WarrantyExtendedItemTran",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "warranty_visit_slot",
                table: "WarrantyExtendedItemTran",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "warranty_visit_charge",
                table: "WarrantyExtendedItemTran");

            migrationBuilder.DropColumn(
                name: "warranty_visit_gap",
                table: "WarrantyExtendedItemTran");

            migrationBuilder.DropColumn(
                name: "warranty_visit_slot",
                table: "WarrantyExtendedItemTran");
        }
    }
}
