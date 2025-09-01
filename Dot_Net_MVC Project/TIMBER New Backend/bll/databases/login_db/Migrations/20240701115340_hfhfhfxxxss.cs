using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class hfhfhfxxxss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "purchase_qty_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "recv_qty_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "sale_qty_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "purchase_qty_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "recv_qty_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "sale_qty_yn",
                table: "System_Records");
        }
    }
}
