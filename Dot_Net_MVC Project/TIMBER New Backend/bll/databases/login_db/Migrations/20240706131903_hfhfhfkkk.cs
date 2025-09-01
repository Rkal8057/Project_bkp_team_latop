using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class hfhfhfkkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "IssueReceiptMaster",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 140);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "IssueReceiptMaster",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 141);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "IssueReceiptMaster");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "IssueReceiptMaster");
        }
    }
}
