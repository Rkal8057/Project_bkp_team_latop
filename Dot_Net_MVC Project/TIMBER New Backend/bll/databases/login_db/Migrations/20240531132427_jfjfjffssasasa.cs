using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class jfjfjffssasasa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "final_amount",
                table: "IssueReceiptMaster",
                type: "decimal(18,2)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 138);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "final_amount",
                table: "IssueReceiptMaster");
        }
    }
}
