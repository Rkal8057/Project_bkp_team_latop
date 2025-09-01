using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfjfjff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "agreement_date",
                table: "PartyMaster",
                newName: "agreement_start_date");

            migrationBuilder.AddColumn<DateTime>(
                name: "agreement_end_date",
                table: "PartyMaster",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 29);

            migrationBuilder.AddColumn<string>(
                name: "type_of_service",
                table: "PartyMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "agreement_end_date",
                table: "PartyMaster");

            migrationBuilder.DropColumn(
                name: "type_of_service",
                table: "PartyMaster");

            migrationBuilder.RenameColumn(
                name: "agreement_start_date",
                table: "PartyMaster",
                newName: "agreement_date");
        }
    }
}
