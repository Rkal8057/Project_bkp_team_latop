using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class jfjfjfjfkkkkkkjjjjjllllddddddddddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "delete_at",
                table: "IssueReceiptTransWarrantyDetail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "delete_at",
                table: "IssueReceiptTransWarrantyDetail");
        }
    }
}
