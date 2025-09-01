using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fjjjgjgjgjgjgjggdddddddsssww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "commission_amt",
                table: "ServiceSubCategoryMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "commission_percentage",
                table: "ServiceSubCategoryMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "commission_type",
                table: "ServiceSubCategoryMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "commission_amt",
                table: "ServiceSubCategoryMaster");

            migrationBuilder.DropColumn(
                name: "commission_percentage",
                table: "ServiceSubCategoryMaster");

            migrationBuilder.DropColumn(
                name: "commission_type",
                table: "ServiceSubCategoryMaster");
        }
    }
}
