using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 39)
                .OldAnnotation("Relational:ColumnOrder", 32);

            migrationBuilder.AddColumn<string>(
                name: "DL_NO",
                table: "PartyMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "anniversary",
                table: "PartyMaster",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 36);

            migrationBuilder.AddColumn<DateTime>(
                name: "dob",
                table: "PartyMaster",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 35);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "PartyMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "important",
                table: "PartyMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "loyalty",
                table: "PartyMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "martital_status",
                table: "PartyMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DL_NO",
                table: "PartyMaster");

            migrationBuilder.DropColumn(
                name: "anniversary",
                table: "PartyMaster");

            migrationBuilder.DropColumn(
                name: "dob",
                table: "PartyMaster");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "PartyMaster");

            migrationBuilder.DropColumn(
                name: "important",
                table: "PartyMaster");

            migrationBuilder.DropColumn(
                name: "loyalty",
                table: "PartyMaster");

            migrationBuilder.DropColumn(
                name: "martital_status",
                table: "PartyMaster");

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 32)
                .OldAnnotation("Relational:ColumnOrder", 39);
        }
    }
}
