using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class jfjfjfjf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "item_warranty_expiry_date",
                table: "IssueReceiptTransDetail",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 39);

            migrationBuilder.AddColumn<string>(
                name: "item_warranty_mode",
                table: "IssueReceiptTransDetail",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "item_warranty_period",
                table: "IssueReceiptTransDetail",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "item_warranty_visit_count",
                table: "IssueReceiptTransDetail",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "item_warranty_expiry_date",
                table: "IssueReceiptTransDetail");

            migrationBuilder.DropColumn(
                name: "item_warranty_mode",
                table: "IssueReceiptTransDetail");

            migrationBuilder.DropColumn(
                name: "item_warranty_period",
                table: "IssueReceiptTransDetail");

            migrationBuilder.DropColumn(
                name: "item_warranty_visit_count",
                table: "IssueReceiptTransDetail");
        }
    }
}
