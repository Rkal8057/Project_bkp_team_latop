using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class hfghhgghdddddnknkn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "unique_number",
                table: "IssueItemExtraDetail",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "unique_number",
                table: "Challan_Single_Item_Master",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "unique_number",
                table: "IssueItemExtraDetail");

            migrationBuilder.DropColumn(
                name: "unique_number",
                table: "Challan_Single_Item_Master");
        }
    }
}
