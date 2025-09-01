using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class jfjfjfjfjf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "item_date",
                table: "ItemMaster",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 54);

            migrationBuilder.AddColumn<string>(
                name: "warranty_period",
                table: "ItemMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "warranty_yes_no",
                table: "ItemMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "item_date",
                table: "ItemMaster");

            migrationBuilder.DropColumn(
                name: "warranty_period",
                table: "ItemMaster");

            migrationBuilder.DropColumn(
                name: "warranty_yes_no",
                table: "ItemMaster");
        }
    }
}
