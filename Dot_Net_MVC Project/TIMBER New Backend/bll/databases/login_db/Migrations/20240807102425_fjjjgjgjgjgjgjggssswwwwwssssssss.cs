using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fjjjgjgjgjgjgjggssswwwwwssssssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "business_card_link",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "business_card_link",
                table: "System_Records");
        }
    }
}
