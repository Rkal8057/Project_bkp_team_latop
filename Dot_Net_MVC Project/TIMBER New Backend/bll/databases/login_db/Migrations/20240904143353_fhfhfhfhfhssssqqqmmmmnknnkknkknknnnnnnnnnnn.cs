using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfhssssqqqmmmmnknnkknkknknnnnnnnnnnn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "document_required_col_size",
                table: "CheckListMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "document_required_option",
                table: "CheckListMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "document_required_col_size",
                table: "CheckListMaster");

            migrationBuilder.DropColumn(
                name: "document_required_option",
                table: "CheckListMaster");
        }
    }
}
