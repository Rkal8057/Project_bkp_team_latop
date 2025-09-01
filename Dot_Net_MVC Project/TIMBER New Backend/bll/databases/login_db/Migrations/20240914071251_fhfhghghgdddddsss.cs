using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhghghgdddddsss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "endDate",
                table: "ActivityMaster");

            migrationBuilder.DropColumn(
                name: "startDate",
                table: "ActivityMaster");

            migrationBuilder.AddColumn<string>(
                name: "activity_end_time",
                table: "ActivityMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "activity_start_time",
                table: "ActivityMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "activity_end_time",
                table: "ActivityMaster");

            migrationBuilder.DropColumn(
                name: "activity_start_time",
                table: "ActivityMaster");

            migrationBuilder.AddColumn<DateTime>(
                name: "endDate",
                table: "ActivityMaster",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<DateTime>(
                name: "startDate",
                table: "ActivityMaster",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 9);
        }
    }
}
