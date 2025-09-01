using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class hfhfhfhfhfsssssqqqqddeeeeeee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "seen_by",
                table: "ContactMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "seen_by_id",
                table: "ContactMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 18);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "seen_by",
                table: "ContactMaster");

            migrationBuilder.DropColumn(
                name: "seen_by_id",
                table: "ContactMaster");
        }
    }
}
