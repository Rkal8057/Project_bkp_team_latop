using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class jfjfjfjfkkkkkkkkkkfhhfhfh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "item_warranty_expiry_date",
                table: "IssueReceiptTransDetail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 45)
                .OldAnnotation("Relational:ColumnOrder", 44);

            migrationBuilder.AddColumn<string>(
                name: "warranty_serial_no",
                table: "IssueReceiptTransDetail",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "warranty_serial_no",
                table: "IssueReceiptTransDetail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "item_warranty_expiry_date",
                table: "IssueReceiptTransDetail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 44)
                .OldAnnotation("Relational:ColumnOrder", 45);
        }
    }
}
